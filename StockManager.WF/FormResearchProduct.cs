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

namespace StockManager.WF
{
    public partial class FormResearchProduct : Form
    {

        
        

        #region Attributs
        private List<Product> _Products;
        private List<Product> _FiltredProducts;
        private List<ProductCategory> _ProductCategories;     

        #endregion
        #region Methode
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }
        public List<Product> FiltredProduct
        {
            get { return _FiltredProducts; }
            set { _FiltredProducts = value; }
        }
        public List<ProductCategory> ProductCategories
        {
            get { return _ProductCategories; }
            set { _ProductCategories = value; }
        }
        #endregion

        #region Constructor
        public FormResearchProduct()
        {
            InitializeComponent();
        }
        #endregion

        #region click events basic fonction
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
        private void FormResearchProduct_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion
    }

}
