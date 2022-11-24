using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectComplaint.BAL
{
    public class ProductBAL
    {
        DAL.ProductDAL objpro = new DAL.ProductDAL();
        private string _name;
        private int _id;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public int productInsert()
        {
            return objpro.ProductInsert(this);
        }
        public DataTable viewProduct()
        {
            return objpro.ViewProduct();
        }
        public int updateProduct()
        {
            return objpro.ProductEdit(this);
        }
        public int deleteProduct()
        {
            return objpro.DeleteProduct(this);
        }
    }
}