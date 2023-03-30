using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Saldo { get; set; }
        public void Pay(double price)
        {
            Saldo = Saldo - price;  
        }
        public void Receber(double price)
        {
            Saldo = Saldo + price;
            
        }
        
    }
}
