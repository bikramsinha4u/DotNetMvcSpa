using Common;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class ProductViewModel : ViewModelBase
    {
        public List<Product> Products { get; set; }
        public Product SearchEntity { get; set; }
        public Product Entity { get; set; }

        protected override void Init()
        {
            Products = new List<Product>();
            SearchEntity = new Product();
            Entity = new Product();

            base.Init();
        }

        public ProductViewModel() : base()
        { }

        protected override void Get()
        {
            ProductManager mgr = new ProductManager();

            Products = mgr.Get(SearchEntity);

            base.Get();
        }

        protected override void ResetSearch()
        {
            SearchEntity = new Product();

            base.ResetSearch();
        }

        protected override void Add()
        {
            IsValid = true;

            Entity = new Product();
            Entity.IntroductionDate = DateTime.Now;
            Entity.Url = "www.my.bit-ly";
            Entity.Price = 57;

            base.Add();
        }

        protected override void Edit()
        {
            ProductManager mgr = new ProductManager();

            Entity = mgr.Get(Convert.ToInt32(EventArgument));

            base.Edit();
        }



        protected override void Save()
        {
            ProductManager mgr = new ProductManager();

            if (Mode == "Add")
            {
                mgr.Insert(Entity);
            }
            else
            {
                mgr.Update(Entity);
            }

            ValidationErrors = mgr.ValidationErrors;

            base.Save();
        }

        protected override void Delete()
        {
            ProductManager mgr = new ProductManager();
            Entity = new Product();
            Entity.ProductId = Convert.ToInt32(EventArgument);

            mgr.Delete(Entity);

            Get();

            base.Delete();
        }

        public override void HandleRequest()
        {
            base.HandleRequest();
        }
    }
}
