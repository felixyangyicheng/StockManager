using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StockManager.WF.Model;


namespace StockManager.WF
{
    public partial class FormManageStockEntry : Form
    {


        #region Attributs
        private List<Product> _Products;
        private List<StockMovement> _StockMovements;
        private List<ProductCategory> _ProductCategories;
        #endregion








        #region Methode
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }
        public List<StockMovement> StockMovements
        {
            get { return _StockMovements; }
            set { _StockMovements = value; }
        }
        public List<ProductCategory> ProductCategories
        {
            get { return _ProductCategories; }
            set { _ProductCategories = value; }
        }
        public string EmployeeCode { get;  set; }
        
        #endregion


        #region Constructor création liste de produits


        private DB dB = new DB();
        #endregion
        public FormManageStockEntry(List<Product> products)
        {   
            Products = products;
            InitializeComponent();
            listOfProduct.DataSource = Products;
            ForceRefreshList();
        }

        

        #region methode refresh
        public void ForceRefreshList()

        {
            GetProductSQL();
            int selectedIndex = listOfProduct.SelectedIndex;
            listOfProduct.DataSource = null;
            listOfProduct.DataSource = Products;
            listOfProduct.DisplayMember = nameof(Product.ProductName);
            listOfProduct.SelectedIndex = (selectedIndex == -1) ? 0 : selectedIndex;

        }

        #endregion

        #region creation produit à partir de sql
        public void GetProductSQL()
        {
            try
            {


                string sql = string.Format($"SELECT  t0.Identifier, t0.Nom, t0.Reference, t0.Price, t0.Description, t0.IdentifierProductCategory FROM Product as t0");
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

            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                dB.CloseConnection();
            }
        }
        #endregion
        #region click events basic fonction
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            _Products.RemoveRange(0, _Products.Count());
            this.Close();
        }
        #endregion

        #region click fonctionnal events
        private void listOfProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int ProductID= ((Product)listOfProduct.SelectedItem).Identifier;
            string StringID = ProductID.ToString();
            textBoxProductID.Text = StringID;
            textBoxProductName.Text = ((Product)listOfProduct.SelectedItem).ProductName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxQuantity.Text == "" || textBoxProductID.Text == "" || textBoxProductName.Text == "")
            {
                MessageBox.Show("Tous les champs doivent petre remplis!");
                return;
            }
            foreach(char item in textBoxQuantity.Text)
            {
                if (!(item >= '0' && item <= '9'))
                {
                    MessageBox.Show("Il faut les chiffres pour la quantié!");
                    return;
                }
            }
            try  /// INSERT d'abord dans la table StockMovement, les valeurs suivant, obtenir la clé primaire, puis INSERT dans la table StockMovementProduct entant que clé étrangère
            { //TODO get Employé CODE
                DateTime saveNow = DateTime.Now;
                string sql1 = string.Format(@"INSERT INTO StockMovement(Date, EmployeeCode, IsStockEntry) VALUES ('{0}','{1},'{2}') SELECT SCOPE_IDENTITY", saveNow, EmployeeCode,1);
                if (dB.ExecuteSQLCommand(sql1) > 0)
                {
                    MessageBox.Show("StockMovement Enregistré!");
                    SqlDataReader dataReader = dB.SelectDataReader(sql1);
                    if (dataReader.HasRows)
                    {
                        //StockMovement stockMovement = new StockMovement();
                        //_StockMovements.Add(stockMovement);

                        int IDStockMovement = dataReader.GetInt32(0);
                        string sql2 = string.Format(@"INSERT INTO StockMovementProduct(IdentifierProduct, IdentifierStockMovement, Quantity VALUES ('{0}','{1}','{2}')", Convert.ToInt32(textBoxProductID.Text), IDStockMovement, Convert.ToDecimal(textBoxQuantity.Text));
                        if (dB.ExecuteSQLCommand(sql2) > 0)
                        {
                            MessageBox.Show("StockMovementProduct Enregistré!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("échoué!");
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
        #endregion

        #region Mouse down event
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
        private void FormManageStockEntry_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region Load Animation
        private void FormManageStockEntry_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
        }



        #endregion

       
    }
}
