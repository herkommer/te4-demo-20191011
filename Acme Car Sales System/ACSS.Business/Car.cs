﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSS.Business
{
    public class Car
    {

        public string Make { get; set; }
        public string Model { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Make, Model);
        }
    }
}
