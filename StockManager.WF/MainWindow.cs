using StockManager.WF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManager.WF
{
    public partial class MainMenu : Form
    {

        private DB dB = new DB();

        private List<ProductCategory> _ProductCategories=new List<ProductCategory>();
        private List<Product> _Products= new List<Product>();
        private List<Staff> _Staffs = new List<Staff>();


        public string EmployeeCode { get; set; }
        


        public MainMenu()
        {
            InitializeComponent();

            _Products = new List<Product>();
            List <ProductCategory> CategorySample= new List<ProductCategory>();
            CategorySample.Add(new ProductCategory());

            _Staffs = new List<Staff>();
            _Staffs.Add(new Staff());

            
        }

        #region Methode Creation à partir de la bases de données
        public void GetCategorySQL()
        {
            try
            {


                string sql = string.Format($"SELECT  t0.Identifier, t0.Label FROM ProductCategory as t0");
                SqlDataReader dataReader = dB.SelectDataReader(sql);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        ProductCategory productCategory = new ProductCategory();
                        _ProductCategories.Add(productCategory);

                        productCategory.IdentifierProductCategory = dataReader.GetInt32(0);
                       
                        if (!dataReader.IsDBNull(2))
                        {
                            productCategory.Label = dataReader.GetString(2);
                        }
                       

                    }
                }


            }

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                dB.CloseConnection();
            }
        }

        public void GetProductSQL()
        {
            try
            {


                string sql = string.Format($"SELECT  t0.Identifier, t0.Nom, t0.Reference, t0.Price, t0.Description, t0.IdentifierProductCategory FROM Product as t0") ;
                SqlDataReader dataReader = dB.SelectDataReader(sql);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Product product = new Product();
                        _Products.Add(product);

                        product.Identifier = dataReader.GetInt32(0);
                        product.ProductName = dataReader.GetString(1);
                        if (!dataReader.IsDBNull(2))
                        {
                            product.Reference = dataReader.GetString(2);
                        }
                        product.Price = dataReader.GetDecimal(3);
                        if (!dataReader.IsDBNull(4))
                        {
                            product.Description = dataReader.GetString(4);
                        }
                        if (!dataReader.IsDBNull(5))
                        {
                            product.ProductCategory = _ProductCategories.First(productCategory => productCategory.IdentifierProductCategory == dataReader.GetInt32(5));
                        }

                    }
                }
                

            }

            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                dB.CloseConnection();
            }
        }
        #endregion

        #region click events main fonction
        private void buttonManageCategory_Click(object sender, EventArgs e)
        {
            FormManageCategory formManageCategory = new FormManageCategory (_ProductCategories, _Products);
            formManageCategory.ShowDialog();


        }

        private void buttonManageProduit_Click(object sender, EventArgs e)
        {
            FormManageProduct formManageProduct = new FormManageProduct(_ProductCategories, _Products);
            formManageProduct.ShowDialog();
        }

        private void buttonManageInStock_Click(object sender, EventArgs e)
        {   


            FormManageStockEntry formManageStockEntry = new FormManageStockEntry(_Products);
            formManageStockEntry.ShowDialog();
            formManageStockEntry.EmployeeCode = labelEmployeeCodeMM.Text;
        }
        private void buttonManageOutStock_Click(object sender, EventArgs e)
        {
            FormManageStockExit formManageStockExit = new FormManageStockExit(_Products);
            formManageStockExit.ShowDialog();
            formManageStockExit.EmployeeCode = labelEmployeeCodeMM.Text;
        }

        private void buttonReserch_Click(object sender, EventArgs e)
        {
            FormResearchProduct formResearchProduct = new FormResearchProduct();
            formResearchProduct.ShowDialog();
        }
        private void buttonManageStaff_Click(object sender, EventArgs e)
        {
            FormManageStaff formManageStaff = new FormManageStaff(_Staffs);
            formManageStaff.ShowDialog();
        }
        #endregion


        #region click events basic fonction
        /// <summary>
        /// Création de boutons pour Minimiser et fermer la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 



        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }






        #endregion

        #region mouse down event

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        /// <summary>
        /// pour qu'on puisse bouger la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region Load window Animation 
        private void MainMenu_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            labelEmployeeCodeMM.Text = string.Format("{0}", EmployeeCode);
        }
        #endregion

        
    }

}
