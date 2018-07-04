﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Sulmar.WPFMVVM.Shop.WPFClient.MarkupExtensions
{
    public class CurrentDate : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return DateTime.Now;
        }
    }
}
