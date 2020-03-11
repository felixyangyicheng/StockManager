using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
	public class StockMovementProduct
    {
		private int _Identifier;
		private int _IdentifierProduct;
		private int _IndetifierStockMovement;
		public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}
		public int IdentifierProduct
		{
			get { return _IdentifierProduct; }
			set { _IdentifierProduct = value; }
		}
		public int IndetifierStockMovement
		{
			get { return _IndetifierStockMovement; }
			set { _IndetifierStockMovement = value; }
		}


	}
}
