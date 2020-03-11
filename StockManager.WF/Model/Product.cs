using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager.WF.Model
{
    public class Product
    {
		private int _Identifier;
		private string _ProductName;
		private string _Reference;
		private Decimal _Price;
		private string _Description;
		private int _IdentifierProductCategory;
		private ProductCategory _ProductCategory;
		public int Identifier
		{
			get { return _Identifier; }
			set { _Identifier = value; }
		}

		public string Fullname
		{
			get { return _ProductName; }
		}

		public string ProductName
		{
			get { return _ProductName; }
			set { _ProductName = value; }
		}
		public string Reference
		{
			get { return _Reference; }
			set { _Reference = value; }
		}		
		public Decimal Price
		{
			get { return _Price; }
			set { _Price = value; }
		}
		public string Description
		{
			get { return _Description; }
			set { _Description = value; }
		}
		public int IdentifierProductCategory
		{
			get { return _IdentifierProductCategory; }
			set { _IdentifierProductCategory = value; }
		}


		public ProductCategory ProductCategory
		{
			get { return _ProductCategory; }
			set { _ProductCategory = value; }
		}


		public Product()
		{

		}
	}
}
