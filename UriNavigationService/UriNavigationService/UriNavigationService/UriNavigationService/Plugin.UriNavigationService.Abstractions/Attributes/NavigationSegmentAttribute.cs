﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.UriNavigationService.Abstractions.Attributes
{
    public class NavigationSegmentAttribute : Attribute
    {
        public NavigationSegmentAttribute(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
