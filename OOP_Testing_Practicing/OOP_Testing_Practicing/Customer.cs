using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Testing_Practicing
{
    public abstract class Customer 
    {
        public string name { get; set; }
        public int id { get; set; }

        public abstract decimal CalculateDiscount(); //abstract class because some implementations not defined
    }


    public class GoldCustomer : Customer
    {
        public override decimal CalculateDiscount()
        {
            throw new NotImplementedException(); // Code on abstract class is defined on child class.
        }
    }
}


