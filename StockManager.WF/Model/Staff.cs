using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    public class Staff
    {
        #region Attribut
        private int _Identifier;

		private string _Name;

		private string _Password;

		private int _Grade;
        #endregion

        #region Propriety
        public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		public string Password
		{
			get { return _Password; }
			set { _Password = value; }
		}
		public int Grade
		{
			get { return _Grade; }
			set { _Grade = value; }
		}
        #endregion

        #region Constructor
        public Staff(string name="staff", string password="Not24get", int grade=1 )
		{
			_Name = (name != "staff") ? name : "staff";
			_Password = (password != "Not24get") ? password : "Not24get";
			_Grade = (grade != 1) ? grade : 1;
		}
        #endregion
    }
}
