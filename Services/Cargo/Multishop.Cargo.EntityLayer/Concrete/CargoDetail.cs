﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multishop.Cargo.EntityLayer.Concrete
{
    public class CargoDetail
    {
        public int CargoDetailId { get; set; }
        public string SenderCustomer { get; set; }
        public string ReceiverCustomer { get; set; }
        public int Barcode { get; set; }
        public int CargoCompanyId { get; set; }
        public CargoCustomer CargoCompany { get; set; }
    }
}
