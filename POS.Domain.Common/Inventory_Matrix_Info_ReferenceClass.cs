﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Common
{
   public class Inventory_Matrix_Info_ReferenceClass
    {
        public int ID { get; set; }
        public string ItemNum { get; set; }
        public string Store_ID { get; set; }
        public string Group_ID { get; set; }
    }
}
