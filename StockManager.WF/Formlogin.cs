using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManager.WF.Model;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace StockManager.WF
{
    public partial class Formlogin : Form
    {
        private DB dB = new DB();
        public Formlogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Animation fenêtre roulante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lonin_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (Root())
            {
                MainMenu mainMenuRoot = new MainMenu();
                mainMenuRoot.EmployeeCode = textBoxEmployeeCode.Text;

                Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
                this.Hide();
                mainMenuRoot.Show();
            }

            else
            {
                if (textBoxEmployeeCode.Text.Equals("") || textBoxPassWord.Text.Equals(""))
                {
                    MessageBox.Show("le code d'employee ou le mot de passe est vide!");
                    return;
                }

                if (!Identification())
                {


                    MessageBox.Show("le code d'employee ou le mot de passe invalide!");
                    return;



                }


                MainMenu mainMenu = new MainMenu();
                mainMenu.EmployeeCode = textBoxEmployeeCode.Text;

                Win32.AnimateWindow(this.Handle, 300, Win32.AW_HIDE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
                this.Hide();
                mainMenu.Show();
            }
            
        }

        #region Methode login ROOT pour debug etc.
        private bool Root()
        {
            bool iden = false;
            if(textBoxEmployeeName.Text=="ROOT"&&textBoxPassWord.Text=="ROOT")
            {
                return iden = true;
            }
            else
            {
                return iden;
            }

        }
        #endregion

        #region Méthode identification pour obtenir la grade de l'employé.
        private bool Identification()
        {
            bool iden = false;

            try
            {

                string sql = string.Format(@"SELECT * FROM Staff where Identifier='{0}' and Password='{1}'", textBoxEmployeeCode.Text, textBoxPassWord.Text);

                SqlDataReader dataReader = dB.SelectDataReader(sql);
                if (dataReader.HasRows)
                {
                    return iden = true;
                }

                if (dataReader.HasRows)
                {
                   while (dataReader.Read())
                   {
                        comboBoxGrade.Text = dataReader[0].ToString();
                    }
                    return iden = true;
                }
                else
                {
                    comboBoxGrade.Text = "grade";
                    return iden;
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return iden;
            }
            finally
            {
                dB.CloseConnection();
            }
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
        private void Formlogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion

        #region click events basic fonction
        /// <summary>
        /// Création de boutons pour Minimiser et fermer la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 





        #endregion

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
