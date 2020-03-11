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
    public partial class FormManageStockExit : Form
    {
        #region Attribut
        private List<Product> _Products;
        #endregion

        #region Methode
        public List<Product> Products
        {
            get { return _Products; }
            set { _Products = value; }
        }

        public string EmployeeCode { get;  set; }
        #endregion
        public FormManageStockExit(List<Product> _Products)
        {
            InitializeComponent();
        }
        #region click events basic fonction
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormManageStockExit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion


        
        private void FormManageStockExit_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            //labelStaff.Text = string.Format("{0}", EmployeeCode);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
