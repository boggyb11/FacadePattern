﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("Check loans for " + customer.Name);
            return true;
        }
    }
}
