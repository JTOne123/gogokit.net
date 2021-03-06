﻿using GogoKit.Models.Response;
using System.Collections.Generic;

namespace ManagingSales.Models
{
    public class SalesViewModel
    {
        public IReadOnlyList<Sale> Sales { get; set; }
        public int? PreviousPage { get; set; }
        public int? NextPage { get; set; }
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
    }
}