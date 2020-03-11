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
using StockManager.WF.Model;
using System.Data.SqlClient;
using StockManager.WF;


namespace StockManager.WF
{
    public partial class FormManageCategory : Form
    {
       

        #region Attributs
        private List<ProductCategory> _ProductCategories;
        private List<Product> _Products;
        #endregion



        public static string _ConnectionString= "Server=localhost\\SQLEXPRESS;Database=StockManager;Integrated security=True;";
        SqlConnection connection = new SqlConnection(_ConnectionString);

        #region Methode
        public List<ProductCategory> ProductCategories
        {
            get { return _ProductCategories; }
            set { _ProductCategories = value; }
        }
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }
        #endregion

        #region Constructor
        public FormManageCategory(List<ProductCategory> productCategories, List<Product> products)
        {
            ProductCategories = productCategories;
            Products = products;
            InitializeComponent();
            ListOfCategory.DataSource = ProductCategories;

            ForceRefreshList();
        }

      

        private DB dB = new DB();
        #endregion

        #region click events basic fonction
        private void buttonMinimize_Click(object sender, EventArgs e)=> this.WindowState = FormWindowState.Minimized;
        private void buttonExit_Click(object sender, EventArgs e)
        {
            // supprimer les instance category de la list avant de fermer

            _ProductCategories.RemoveRange(0, _ProductCategories.Count());
            this.Close();
        }
        #endregion


        private void ListOfCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListOfCategory.SelectedItem is ProductCategory)
            {
                int ID= ((ProductCategory)ListOfCategory.SelectedItem).IdentifierProductCategory;
                string StringID = ID.ToString();
                textBoxCategoryID.Text = StringID;

                textBoxCategoryName.Text = ((ProductCategory)ListOfCategory.SelectedItem).Label;
                //référence au projet Videos
                // ListOfProduct.DataSource = null;
                //ListOfProduct.DataSource = ((Product)listBoxVideos.SelectedItem).Tags;
                //ListOfProduct.DisplayMember = nameof(Tag.FullName);
                LoadProductName();


            }
        }

        

        #region Methode charger nom des produits
        private void LoadProductName()
        {
           

            try
            {
                if (textBoxCategoryName.Text != "")
                {
                    string sql = string.Format(@"SELECT t0.Nom FROM Product as t0 INNER JOIN ProductCategory as t1 ON t0.IdentifierProductCategory=t1.Identifier WHERE Label='{0}'", textBoxCategoryName.Text);
                    DataSet dataSet = dB.GetDataSet(sql, "Product");
                    
                    ListOfProduct.DataSource = null;
                    ListOfProduct.DataSource = dataSet.Tables[0] ;
                    ListOfProduct.DisplayMember = dataSet.Tables[0].Columns[0].ToString();
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
        #region Methode creation à partir de la base
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

                        if (!dataReader.IsDBNull(1))
                        {
                            productCategory.Label = dataReader.GetString(1);
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


        #region methode refresh
        public void ForceRefreshList()
        {
            GetCategorySQL();
            int selectedIndex = ListOfCategory.SelectedIndex;
            ListOfCategory.DataSource = null;
            ListOfCategory.DataSource = ProductCategories;
            ListOfCategory.DisplayMember = nameof(ProductCategory.Label);
            ListOfCategory.SelectedIndex = (selectedIndex == -1) ? 0 : selectedIndex;


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
        private void FormManageCategory_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion


        // Ajouter une catégory
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {

          

            if (textBoxCategoryName.Text == "")
            {
                MessageBox.Show("Il lui faut un Nom de catégory de produit!");
                return;
            }


            try
            {
                
                string sql = string.Format(@"INSERT into ProductCategory(Label) values('{0}')", textBoxCategoryName.Text);
                if (dB.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("Nouvelle Catégorie ajoutée!");
                    ((ProductCategory)ListOfCategory.SelectedItem).Label = textBoxCategoryName.Text;
                    ListOfCategory.Refresh();
                    //this.Close();
                }
                else
                {
                    MessageBox.Show("l'ajout de nouvelle catégorie échoué!");
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

        // Mettre à jour de catégorie

        //private void UpdateCategory(ProductCategory productCategory)
        //{
        //    SqlConnection connection = new SqlConnection(_ConnectionString);
        //    SqlCommand sqlCommand = new SqlCommand("$UPDATE ProductCategory SET" +$"[Label]=@Label"+$"WHERE [Identifier]=@Identifier", connection);


        //    sqlCommand.Parameters.AddWithValue("Identifier", (object)productCategory.IdentifierProductCategory ?? DBNull.Value);
        //    sqlCommand.Parameters.AddWithValue("Label", (object)productCategory.Label ?? DBNull.Value);
        //    connection.Open();
        //        if (sqlCommand.ExecuteNonQuery() > 0)
        //        {
        //            MessageBox.Show("Mise à jour réussite!");
        //            ((ProductCategory)ListOfCategory.SelectedItem).Label = textBoxCategoryName.Text;
        //            ListOfCategory.Refresh();
        //            this.Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Cette catégorie n'existe pas, veuillez renseigner le nom de la catégorie!");
        //        }
        //}

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            if (textBoxCategoryName.Text == "")
            {
                MessageBox.Show("Il lui faut un Nom de catégory de produit pour la mise à jour!");
                return;
            }
            try
            {
                string sql = string.Format(@"UPDATE ProductCategory SET Label='{0}' WHERE Identifier='{1}'", textBoxCategoryName.Text, Convert.ToInt32(textBoxCategoryID.Text));
                if (dB.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("Modification Réussite!");
                    this.Close();
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

        //suppression de catégorie 
        private void buttonDelectCategory_Click(object sender, EventArgs e)
        {

            if (ListOfCategory.SelectedItem is ProductCategory)
            {
                try
                {
                    string sql = string.Format(@"DELETE ProductCategory WHERE (Label='{0}')", textBoxCategoryName.Text);
                    if (dB.ExecuteSQLCommand(sql) > 0)
                    {
                        MessageBox.Show("Suppression réussite!");
                        _ProductCategories.Remove((ProductCategory)ListOfCategory.SelectedItem);
                        ListOfCategory.Refresh();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cette catégorie n'existe pas, veuillez renseigner le nom de la catégorie!");
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
            
        }
    }
}
