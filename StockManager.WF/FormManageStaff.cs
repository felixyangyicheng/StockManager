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

namespace StockManager.WF
{
    public partial class FormManageStaff : Form
    {
        #region Attributs
        private List<Staff> _Staffs;
        #endregion
        #region Methode
        public List<Staff> Staffs
        {
            get { return _Staffs; }
            set { _Staffs = value; }
        }
        #endregion

        #region Constructor création liste de Staff
        public FormManageStaff(List<Staff> staffs)
        {
            Staffs = staffs;
            InitializeComponent();
            listOfStaff.DataSource = Staffs;

        }
        private DB dB = new DB();
        #endregion

        #region Methode Creation à partir de SQL
       private void GetStaffSQL()
        {
            try
            {
                string sql = string.Format($"SELECT t0.Identifier, t0.Name, t0.Password, t0.Grade FROM Staff as t0");
                SqlDataReader dataReader = dB.SelectDataReader(sql);
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Staff staff = new Staff();
                        _Staffs.Add(staff);

                        staff.Identifier = dataReader.GetInt32(0);
                        staff.Name = dataReader.GetString(1);
                        staff.Password = dataReader.GetString(2);
                        staff.Grade = dataReader.GetInt32(3);
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
            GetStaffSQL();

            int selectedIndex = listOfStaff.SelectedIndex;
            listOfStaff.DataSource = null;
            listOfStaff.DataSource = Staffs;
            listOfStaff.DisplayMember = nameof(Staff.Name);
            //listOfStaff.SelectedIndex = (selectedIndex == -1) ? 0 : selectedIndex;
        }
        #endregion


        #region Click Fonctionnal events
        private void listOfStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listOfStaff.SelectedItem is Staff)
            {
                int StaffID = ((Staff)listOfStaff.SelectedItem).Identifier;
                string StringID = StaffID.ToString();
                textBoxStaffID.Text = StringID;

                textBoxStaffName.Text = ((Staff)listOfStaff.SelectedItem).Name;
                textBoxPassword.Text = ((Staff)listOfStaff.SelectedItem).Password;

                int StaffGrade = ((Staff)listOfStaff.SelectedItem).Grade;
                string StringGrade = StaffGrade.ToString();
                textBoxStaffGrade.Text = StringGrade;
            }
        }

        //Delete
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listOfStaff.SelectedItem is Staff)
            {
                try
                {
                    string sql = string.Format(@"DELETE Staff WHERE (Name='{0}')",textBoxStaffName.Text);
                    if (dB.ExecuteSQLCommand(sql) > 0)
                    {
                        MessageBox.Show("Employé supprimé!");
                        _Staffs.Remove((Staff)listOfStaff.SelectedItem);
                        listOfStaff.Refresh();
                        
                    }
                    else
                    {
                        MessageBox.Show("échoué!");

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
        }

        // Ajouter un employé
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxStaffName.Text == "")
            {
                MessageBox.Show("le nom de l'employé est nécessaire pour executer l'ajout.");
                return;
            }
            foreach(char item in textBoxStaffGrade.Text)
            {
                if (!(item >= '0' && item <= '9'))
                {
                    MessageBox.Show("La grade doit être composée uniquement des chiffres!");
                    return;
                }
            }
            try
            {
                string sql = string.Format(@"INSERT INTO Staff(Name, Password, Grade) VALUES ('{0}','{1}','{2}')", textBoxStaffName.Text, textBoxPassword.Text, Convert.ToInt32(textBoxStaffGrade.Text));
                if (dB.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("Ajouté!");
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

        //Update 
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format(@"UPDATE Staff SET Name='{0}', Password='{1}', Grade='{2}'", textBoxStaffName.Text, textBoxPassword.Text, Convert.ToInt32(textBoxStaffGrade.Text));
                if (dB.ExecuteSQLCommand(sql) > 0)
                {
                    MessageBox.Show("Modification réussite!");

                    listOfStaff.Refresh();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("échoué");

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
        private void FormManageStaff_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
        #region Load window Animation 

        

        private void FormManageStaff_Load(object sender, EventArgs e)
        {
            Win32.AnimateWindow(this.Handle, 300, Win32.AW_ACTIVATE | Win32.AW_VER_POSITIVE | Win32.AW_SLIDE);
            
        }



        #endregion

      
    }
}
