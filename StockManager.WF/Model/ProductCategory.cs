using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
   public class ProductCategory
    {
		private int _IdentifierProductCategory;
		private string _Label;
		private List<Product> _Products;
		public int IdentifierProductCategory
		{
			get { return _IdentifierProductCategory; }
			set { _IdentifierProductCategory = value; }
		}

		public string Label
		{
			get { return _Label; }
			set { _Label = value; }
		}

		public List<Product> Products
		{
			get { return _Products; }
			set { _Products = value; }
		}


	
	}
}
