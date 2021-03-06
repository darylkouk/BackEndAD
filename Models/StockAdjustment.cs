﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndAD.Models
{
    public class StockAdjustment
    {
        public int Id { get; set; }
        public string type { get; set; }
        public DateTime date { get; set;}
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public List<StockAdjustmentDetail> StockAdjustmentDetails { get; set; }
    }
}
