﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_MVC.Root.ViewModels
{

    public class CategoryViewModel
    {
        public int IDCategory { get; set; }
        public string CategoryName { get; set; }
        public DateTime CategoryCreatedDate { get; set; }
        public string CategoryIsActive { get; set; }
    }
}
