using Sulmar.WPFMVVM.Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.ViewModels
{
    //class ViewModelFactory
    //{
    //    public static BaseViewModel Create(object name)
    //    {
    //        string viewname = (string)name;

    //        switch(viewname.ToLower())
    //        {
    //            case "products" : return new ProductsViewModel();
    //            case "customers": return new CustomersViewModel();
    //            // case "orders": return new OrdersViewModel();

    //            default: throw new NotSupportedException();
    //        }
    //    }
    //}


    public interface IViewModelLocator
    {
        BaseViewModel Get(object name);

        BaseViewModel Create(string viewname);
    }

    public class ViewModelLocator : IViewModelLocator
    {
        private IDictionary<string, BaseViewModel> viewModels = new Dictionary<string, BaseViewModel>();

        public BaseViewModel Get(object name)
        {
            string viewname = (string)name;

            if (!viewModels.TryGetValue(viewname, out BaseViewModel viewModel))
            {
                viewModel = Create(viewname);

                viewModels.Add(viewname, viewModel);
            }

            return viewModel;

        }

        public BaseViewModel Create(string viewname)
        {
            string classname = "Sulmar.WPFMVVM.Shop.ViewModels." + viewname + "ViewModel";

            Type type = Type.GetType(classname);

            BaseViewModel viewModel = (BaseViewModel)Activator.CreateInstance(type);
            return viewModel;
        }
    }


}
