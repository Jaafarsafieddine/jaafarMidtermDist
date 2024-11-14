using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Advanced2
{
    public class Customer
    {
        public String name;
        public Bankaccount account;
        public Customer(String name,Bankaccount a) {
                this.name = name;
                this.account = a;
        }
    }
}
