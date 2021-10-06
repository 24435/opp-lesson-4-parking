using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lesson_4_parking.models
{
    public class Customer
    {
        
        public int hoursParked { get; set; }

        public string Registration { get; set; }
        
        public Customer(string _registration ,int _hoursParked)
        {
            Console.Write("");
            Registration = _registration;
            hoursParked = _hoursParked;
        }

        public override string ToString()
        {
            return "I am the Customer";
        }
    }
}
