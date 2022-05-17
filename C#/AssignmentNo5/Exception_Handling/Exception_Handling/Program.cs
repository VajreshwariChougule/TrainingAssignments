using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    public class WithdrawnException : ApplicationException
    {
        public WithdrawnException(string msg) : base(msg)
        {

        }

    }
    public class Bank_Details
    {
        int money = 50000;
        String account_holder = "Vajreshwari";
        String accountnumber;
        static String bank_name = "HDFC";
        static public int actualBalance;

        public Bank_Details()
        {
            Console.WriteLine("Enter the Account Number : ");
            accountnumber = Console.ReadLine();
            Console.WriteLine("Enter the Account holder Name :");
            account_holder = Console.ReadLine();

            Console.WriteLine($"The Account details is : AccountNum {accountnumber}, Account holder name {account_holder}, Amount is {money}");

        }
        public void depositMoney()
        {

            Console.WriteLine("Please enter the amount greater than zero to deposit:");
            int depMoney = int.Parse(Console.ReadLine());
            actualBalance = money + depMoney;
            if (depMoney == 0)
            {
                Console.WriteLine("Minimum deposit should be greater than 500");
            }
            else
            {
                Console.WriteLine("Your updated balance after deposit is " + actualBalance);
            }

        }
        public void dowithdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw:");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            actualBalance = actualBalance - withdraw;
            if (withdraw > actualBalance)
            {
                Console.WriteLine("Sorry, insuffiecient balance");
            }
            else
            {
                Console.WriteLine("Your updated balance after withdrawal is " + actualBalance);
            }

        }
        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Details bank = new Bank_Details();
            try
            {
                bank.depositMoney();
                bank.dowithdraw();

            }
            catch (WithdrawnException we)
            {
                Console.WriteLine(we.Message);
            }
            catch(FormatException fe)
            {
                Console.WriteLine($"Enter only numbers ", fe);
            }
            Console.Read();
        }
    }
}


 
