﻿using Sulmar.WPFMVVM.Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sulmar.WPFMVVM.Shop.IServices
{
    public interface IProductsService
    {
        IList<Product> Get();
        Product Get(int id);
    }
}
