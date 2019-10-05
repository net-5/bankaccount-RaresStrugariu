using System;
using System.Collections.Generic;
using System.Text;


namespace BankAccount_Rares
{
   public enum StatusAccount
   {
      Open,
      Closed
   }
   
   public class BankAccount
   {
      protected string _owner;
      protected string _accountNumber;
      protected decimal _balance;
      private StatusAccount status;

      public string Owner
      {
         get { return _owner; }
         
      }
      public string AccountNumber
      {
         get { return _accountNumber; }
         
      }
      public decimal Balance
      {
         get { return _balance; }
         
      }
      public StatusAccount Status
      {
         get { return status; }
         set { status = value; }

      }

      public BankAccount(string owner, string accountNumber, decimal balance, StatusAccount status)
      {
         _owner = owner;
         _accountNumber = accountNumber;
         _balance = balance;
         this.status = status;
         
         Console.WriteLine($"Account Name: {Owner}\n Accout number: {AccountNumber}\n Accout Balance: {Balance}\n Account Status: {Status} \n");

      }


      public void WithdrawMoney(decimal amount)
      {
         if (status == StatusAccount.Open)
         {
            _balance -= amount;
            
         }
         else
         {
            throw new StatusClosed();
         }
      }

      public void DepositMoney(decimal amount)
      {
         if (status == StatusAccount.Open)
         {
            _balance += amount;
            
         }
         else
         {
            throw new StatusClosed();
         }
      }

      

   }
}
