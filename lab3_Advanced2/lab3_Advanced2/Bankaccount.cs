using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_Advanced2
{
    public class Bankaccount
    {
        public int id;
        public double balance;
        public string name;

        public Bankaccount(int id,double balance,string name) { 
            this.id = id;
            this.balance = balance;
            this.name = name;
        }
    }
}
