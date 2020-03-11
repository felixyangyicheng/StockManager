using StockManager.WF.Model;
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

namespace StockManager.WF
{
    public partial class FormManageProduct : Form
    {

        #region Attributs
        private List<Product> _Products;
        private List<ProductCategory> _ProductCategories;
        #endregion





        #region Methode
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }
        public List<ProductCategory> ProductCategories
        {
            get { return _ProductCategories; }
            set { _ProductCategories = value; }
        }
        #endregion


        #region Constructor création liste de produits
        public FormManageProduct(List<ProductCategory> productCategories, List<Product> products)
        {
            Products = products;
            ProductCategories = productCategories;
            InitializeComponent();
            listOfProduct.DataSource = Products;
            ForceRefreshList();
        }

        public FormManageProduct()
        {

        }

        private DB dB = new DB();
        #endregion

        #region Click fonctionnal events
        private void listOfProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfProduct.SelectedItem is Product)
            {
                int ProductID= ((Product)listOfProduct.SelectedItem).Identifier;
                string StringID = ProductID.ToString();
                textBoxProductID.Text = StringID;

                textBoxProductName.Text = ((Product)listOfProduct.SelectedItem).ProductName;
                textBoxProductReference.Text = ((Product)listOfProduct.SelectedItem).Reference;

                #region convertir décimal en string
                decimal Prix=((Product)listOfProduct.SelectedItem).Price;
                string StringPrix = Prix.ToString();
                textBoxProductPrice.Text = StringPrix;
                #endregion

                textBoxProductDescription.Text = ((Product)listOfProduct.SelectedItem).Description;

                int ProductCategoryID= ((Product)listOfProduct.SelectedItem).IdentifierProductCategory;
                string StringProductCategoryID = ProductCategoryID.ToString();
                textBoxProductCategoryID.Text = StringProductCategoryID;


                

             
            }
        }

        /// supprimer un produit

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listOfProduct.SelectedItem is ProductCategory)
            {
                try
                {
                    string sql = string.Format(@"DELETE Product WHERE (Nom='{0}')", textBoxProductName.Text);
                    if (dB.ExecuteSQLCommand(sql) > 0)
                    {
                        MessageBox.Show("Suppression réussite!");
                        _Products.Remove((Product)listOfProduct.SelectedItem);
                        listOfProduct.Refresh();
                        this.Close();
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
        }

        //Ajouter un produit
        private void buttonAdd_Click(object sender, EventArgs e)
        {


            if (textBoxProductName.Text == "" || textBoxProductReference.Text == "" || textBoxProductPrice.Text == "" || textBoxProductDescription.Text == "" || textBoxProductCategory.Text == "")
            {
                MessageBox.Show("Le produit doit porter un nom, une référence, un prix, une description et une catégorie");
                return;
            }
            foreach (char item in textBoxProductPrice.Text)
            {
                if (!(item >= '0' && item <= '9'))
                {
                    MessageBox.Show("Il faut les chiffres pour le prix!");
                    return;
                }
            }

            try
            {
                string sql = string.Format(@"INSERT INTO Product(Nom, Reference, Price, Description, IdentifierProductCategory) VALUES ('{0}','{1}','{2}','{3}','{4}')", textBoxProductName.Text, textBoxProductReference.Text, Convert.ToDouble(textBoxProductPrice.Text), textBoxProductDescription.Text, Convert.ToInt32(textBoxProductCategoryID.Text));
                if (dB.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("Ajouté");
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

        // Mettre à jour un produit
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listOfProduct.SelectedItem is ProductCategory)
            {
                if (textBoxProductName.Text == "" || textBoxProductReference.Text == "" || textBoxProductPrice.Text == "" || textBoxProductDescription.Text == "" || textBoxProductCategory.Text == "")
                {
                    MessageBox.Show("Le produit doit porter un nom, une référence, un prix, une description et une catégorie");
                    return;
                }
                foreach (char item in textBoxProductPrice.Text)
                {
                    if (!(item >= '0' && item <= '9'))
                    {
                        MessageBox.Show("Il faut les chiffres pour le prix!");
                        return;
                    }
                }
                try
                {
                    string sql = string.Format(@"UPDATE Product SET Nom='{0}', Reference='{1}', Price='{2}', Description='{3}',IdentifierProductCategory='{4}' WHERE(Identifier='{5}')", textBoxProductName.Text, textBoxProductReference.Text, Convert.ToDouble(textBoxProductPrice.Text), textBoxProductDescription.Text, Convert.ToInt32(textBoxProductCategoryID.Text), Convert.ToInt32(textBoxProductID.Text));
                    if (dB.ExecuteSQLCommand(sql) > 0)
                    {

                        MessageBox.Show("Modification réussite!");

                        listOfProduct.Refresh();
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
        }

        private void buttonManageEntry_Click(object sender, EventArgs e)
        {
            FormManageStockEntry formManageStockEntry = new FormManageStockEntry(Products);
            formManageStockEntry.ShowDialog();
        }

        private void labelCategoryID2_Click(object sender, EventArgs e)
        {

        }

        private void listOfCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOfCategory.SelectedItem is ProductCategory)
            {
                int ID = ((ProductCategory)listOfCategory.SelectedItem).IdentifierProductCategory;
                string StringID = ID.ToString();
                textBoxCategory2.Text = StringID;


            }
        }
        #endregion




        #region click events basic fonction
        ///<summary>
        ///
        /// Création de boutton pour minimiser la fenêtre et pour fermer la fenêtre.
        /// 
        /// </summary>
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            _Products.RemoveRange(0, _Products.Count());
            _ProductCategories.RemoveRange(0, _ProductCategories.Count());

            this.Close();
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
        private void FormManageProduct_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region methode creation à partir de la base
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
                        //if (!dataReader.IsDBNull(5))
                        //{
                        //    product.ProductCategory = _ProductCategories.First(productCategory => productCategory.IdentifierProductCategory == dataReader.GetInt32(5));
                        //}

                        
                            product.ProductCategory = _ProductCategories.First(productCategory => productCategory.IdentifierProductCategory == dataReader.GetInt32(5));
                        

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
            GetProductSQL();
            
            int selectedIndex = listOfProduct.SelectedIndex;
            listOfProduct.DataSource = null;
            listOfProduct.DataSource = Products;
            listOfProduct.DisplayMember = nameof(Product.ProductName);
            listOfProduct.SelectedIndex = (selectedIndex == -1) ? 0 : selectedIndex;

            GetCategorySQL();
            int selectedIndex2= listOfCategory.SelectedIndex;
            listOfCategory.DataSource = null;
            listOfCategory.DataSource = ProductCategories;
            listOfCategory.DisplayMember = nameof(ProductCategory.Label);
            listOfCategory.SelectedIndex = (selectedIndex2 == -1) ? 0 : selectedIndex2;

        }


        #endregion


      
        
    }
}
