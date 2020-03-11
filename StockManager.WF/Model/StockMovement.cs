using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    public class StockMovement
    {
		private int _Identifier;
		private DateTime _Date;
		private int _EmployesCode;
		private Boolean _IsStockEntry;
		public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}
		public DateTime Date
		{
			get { return _Date; }
			set { _Date = value; }
		}
		public int EmployesCode
		{
			get { return _EmployesCode; }
			set { _EmployesCode = value; }
		}
		public Boolean IsStockEntry
		{
			get { return _IsStockEntry; }
			set { _IsStockEntry = value; }
		}

	}
}
