using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class06.Exercise3.Models
{
    class Atm
    {
        Customer[] customers;
        public void Main()
        {
            customers = new Customer[]
            {
                new Customer("Aneta S", 1111_2222_3333_4444, 1234, 70_000),
                new Customer("Aeksandar Z", 2222_3333_4444_5555, 2345, 120_000),
                new Customer("Stefan I", 3333_4444_5555_6666, 3456, 45000),
                new Customer("Marija K", 4444_5555_6666_7777, 4567, 180_000)
            };

            Console.WriteLine("Welcome to the ATM app!");
            Customer customer = CheckForCustomer();
            if(customer == null)
            {
                bool answer = YesOrNo("There is no such user! Do you want to register a new card? If yes, press Y, if no, press N");
                if (answer)
                {
                    customer = RegisterCustomer();
                }
                else
                {
                    return;
                }
            }

            //Offer three options
            while (true)
            {
                Console.WriteLine("Please choose an option \nFor balance check press 1.\nFor cash withdrawal press 2.\nFor cash deposit press 3.\nTo exit press any other key.");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    CheckBalance(customer);
                }
                else if (choice == "2")
                {
                    CashWithdrawal(customer);
                }
                else if (choice == "3")
                {
                    CashDeposit(customer);
                }
                else
                {
                    return;
                }

                if (!YesOrNo("Do you want another transaction? Y/N"))
                {
                    Console.WriteLine("Thank you for using our app");
                    return;
                } 
            }

            //If (customer == null)
            //Ask to register 
            //Offer three options
            //CheckBallance
            //WithdrawCash
            //DepositCash
            //Ask if user wants another transaction
            //if(no)
            //End
        }

        public Customer CheckForCustomer()
        {
            long cardNumber = validateCardNumber();
            Customer currentCustomer = null;
        
            for (int i = 0; i < customers.Length; i++)
            {
                if (cardNumber == customers[i].CardNumber)
                {
                    currentCustomer = customers[i];      
                }
            }
            if (currentCustomer != null)
            {
                int pin = AskForPin();
                if(pin == currentCustomer.GetPin())
                {
                    Console.WriteLine("Welcome to your account!");
                    return currentCustomer;
                }
                else
                {
                    Console.WriteLine("The pin is not invalid.");
                    return null;
                }
            }
            return null;
        }

        public int CheckBalance(Customer customer)
        {
            Console.WriteLine($"Your current balance is {customer.GetBalance()}");
            return customer.GetBalance();
        }

        public void CashWithdrawal(Customer customer)
        {
            Console.WriteLine("Enter the cash you want to withdraw:");
            string userInput = Console.ReadLine();
            bool isValidInput = int.TryParse(userInput, out int withdrawnCash);
            if(withdrawnCash > customer.GetBalance())
            {
                Console.WriteLine("You don't have enough money. Try again with another amount.");
            }
            customer.SetBalance(customer.GetBalance() - withdrawnCash);
            Console.WriteLine($@"You withdrew {withdrawnCash}$. You have {customer.GetBalance()}$ left on your account.");
        }

        public void CashDeposit(Customer customer)
        {
            Console.WriteLine("Enter the cash you want to deposit.");
            string userInput = Console.ReadLine();
            bool isValidInput = int.TryParse(userInput, out int depositedCash);
            customer.SetBalance(customer.GetBalance() + depositedCash);
            Console.WriteLine($@"You added {depositedCash}$ on your account. You current bank account is {customer.GetBalance()}$");
        }

        public Customer RegisterCustomer()
        {
            Customer resultCustomer = null;
            Console.WriteLine("Enter your full name");
            string fullName = Console.ReadLine();
            long cardNumber = validateCardNumber();
            Console.WriteLine("Enter your pin");
            int pin = validatePin();
            resultCustomer = new Customer(fullName, cardNumber, pin);
            return resultCustomer;
        }

        public long AskForCardNumber()
        {
            Console.WriteLine("Enter your card number");
            string rawUserInputCard = Console.ReadLine();
            string userInputCard = rawUserInputCard.Replace("-", "");
            bool isValidInputCard = long.TryParse(userInputCard, out long cardNumber);
            if (isValidInputCard)
            {
            return cardNumber;
            }
            return 0;
        }

        public long validateCardNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter a card number");
                string inputCardNumber = Console.ReadLine();
                inputCardNumber = inputCardNumber.Replace("-", "");
                if (inputCardNumber[0] == '0' || inputCardNumber.Length != 16)
                {
                    Console.WriteLine("Your credit card number shouldnt start with zero and must be 16 characters long");
                }
                bool isValidCardNumber = long.TryParse(inputCardNumber, out long cardNumber);
                if (isValidCardNumber)
                {
                    return cardNumber;
                }
                else
                {
                    Console.WriteLine("The enterered input is not a number. Please try again");
                }
            }
        }

        public int AskForPin()
        {
            Console.WriteLine("Enter your pin");
            string userInputPin = Console.ReadLine();
            bool isValidInputPin = int.TryParse(userInputPin, out int pin);
            if (isValidInputPin)
            {
                return pin;
            }
            return 0;
        }

        public int validatePin()
        {
            while (true)
            {
                string inputPin = Console.ReadLine();
                bool isValidPin = int.TryParse(inputPin, out int pin);
                if (isValidPin)
                {
                    if (pin < 1000 && pin > 9999)
                    {
                        Console.WriteLine("Your pin must be a number between 1000 and 9999");
                    }
                    else
                    {
                        return pin;
                    }
                }
            }
        }

        public bool YesOrNo(string choice)
        {
            Console.WriteLine(choice);
            string response = Console.ReadLine();

            while (true)
            {
                if (response == "Y")
                {
                    return true;
                }
                else if (response == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You pressed wrong button. Try again with Y or N");
                }
            }
        }

        private void resizeArr(Customer customer, Customer[] customers)
        {
            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = customer;
        }
    }
}
