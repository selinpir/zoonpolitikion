﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    public class GetCategoryQueryResult
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
