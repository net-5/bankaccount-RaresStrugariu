using System;

namespace BankAccount_Rares
{
   class Program
   {
      static void Main(string[] args)
      {

         try
         {
            BankAccount raresAccount = new BankAccount("Rares", "666666666", 250.50m, StatusAccount.Open);
            raresAccount.DepositMoney(800);
            raresAccount.WithdrawMoney(400);
            
         }
         catch (StatusClosed message)
         {
            Console.WriteLine(message.Message);
         }

         BankAccount emanuelAccount = new BankAccount("Emanuel", "777777777", 550.50m, StatusAccount.Closed);
         try
         {
            emanuelAccount.DepositMoney(100);
            emanuelAccount.WithdrawMoney(100);
         }
         catch (StatusClosed message)
         {
            Console.WriteLine(message.Message);
         }

         


      }

   }
   
}
