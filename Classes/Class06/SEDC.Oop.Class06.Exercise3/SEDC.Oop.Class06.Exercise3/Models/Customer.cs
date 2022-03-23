using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class06.Exercise3.Models
{
    public class Customer
    {
        public string FullName { get; }
        public long CardNumber { get; }
        //public int Pin { get; }
        //public int Balance { get; set; } 

        private int pin;
        private int balance;

        public Customer(string fullName, long cardNumber, int pin)
        {
            FullName = fullName;
            balance = 0;
            CardNumber = cardNumber;
            this.pin = pin;
        }

        public Customer(string fullName, long cardNumber, int pin, int balance)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            this.pin = pin;
            this.balance = balance;
        }

        public void SetBalance(int balance)
        {
            this.balance = balance;
        }

        public int GetBalance()
        {
            return balance;
        }

        public int GetPin()
        {
            return pin;
        }
    }

    
}
