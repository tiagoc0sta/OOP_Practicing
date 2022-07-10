using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Testing_Practicing
{
    public interface Contractor
    {
        public string name { get; set; }
        public int id { get; set; }

        public abstract decimal CalculateDiscountContractor(); 
    }

   
}
