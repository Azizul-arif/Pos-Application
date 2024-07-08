﻿using PosApplication.Models;

namespace PosApplication.ViewModel
{
    public class SalesViewModel
    {
        public int SelectedCategoryId { get; set; }
        public IEnumerable<Category> Categories { get; set; }=new List <Category>();
    }
}
