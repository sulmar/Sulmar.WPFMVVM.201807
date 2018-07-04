using Sulmar.WPFMVVM.Shop.IServices;
using Sulmar.WPFMVVM.Shop.MockServices;
using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {
        public IList<Product> Products { get; set; }

        private readonly IProductsService productsService;


        public ProductsViewModel()
            : this(new MockProductsService())
        {

        }

        public ProductsViewModel(IProductsService productsService)
        {
            this.productsService = productsService;

            Load();
        }

        public void Load()
        {
            Products = productsService.Get();
        }

    }
}
