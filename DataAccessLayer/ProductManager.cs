using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class ProductManager
    {
        public ProductManager()
        {
            ValidationErrors = new List<KeyValuePair<string, string>>();
        }
        public List<KeyValuePair<string, string>> ValidationErrors { get; set; }

        public bool Validate(Product entity)
        {
            ValidationErrors.Clear();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                if (entity.ProductName.ToLower() == entity.ProductName)
                {
                    ValidationErrors.Add(new KeyValuePair<string, string>("ProductName", "Product Name must not be all in lower case."));
                }
            }

            return (ValidationErrors.Count == 0);
        }

        public bool Delete(Product entity)
        {
            // TODO: Create DELETE code here.

            return true;
        }

        public Product Get(int productId)
        {
            List<Product> list = new List<Product>();
            Product ret = new Product();

            // TODO: Call your data access method here.
            list = CreateMockData();

            ret = list.Find(p => p.ProductId == productId);

            return ret;
        }

        public bool Update(Product entity)
        {
            bool ret = false;

            ret = Validate(entity);

            if (ret)
            {
                // TODO: Create UPDATE code here.
            }

            return ret;
        }

        private List<Product> CreateMockData()
        {
            List<Product> ret = new List<Product>();

            ret.Add(new Product() { ProductId = 1, ProductName = "Product-1", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-1", Price = Convert.ToDecimal(29.00) });
            ret.Add(new Product() { ProductId = 2, ProductName = "Product-2", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-2", Price = Convert.ToDecimal(30.00) });
            ret.Add(new Product() { ProductId = 3, ProductName = "Product-3", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-3", Price = Convert.ToDecimal(31.00) });
            ret.Add(new Product() { ProductId = 4, ProductName = "Product-4", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-4", Price = Convert.ToDecimal(32.00) });
            ret.Add(new Product() { ProductId = 5, ProductName = "Product-5", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-5", Price = Convert.ToDecimal(33.00) });
            ret.Add(new Product() { ProductId = 6, ProductName = "Product-6", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-6", Price = Convert.ToDecimal(34.00) });
            ret.Add(new Product() { ProductId = 7, ProductName = "Product-7", IntroductionDate = Convert.ToDateTime("4/5/2016"), Url = "www.bit.ly/xyz-7", Price = Convert.ToDecimal(35.00) });

            return ret;
        }

        public List<Product> Get(Product entity)
        {
            List<Product> ret = new List<Product>();

            ret = CreateMockData();

            if (!string.IsNullOrEmpty(entity.ProductName))
            {
                ret = ret.FindAll(p => p.ProductName == entity.ProductName);
            }

            return ret;
        }

        public bool Insert(Product entity)
        {
            bool ret = false;

            ret = Validate(entity);

            if (ret)
            {
                // TODO: Create insert code here
            }

            return ret;
        }
    }
}
