using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class Customer
    {
        public string User_ID { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int Point { get; set; }
        public bool isVip { get; set; }
        public Customer() { }
        ~Customer() { }
    }
}
