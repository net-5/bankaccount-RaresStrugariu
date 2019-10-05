using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount_Rares
{
   
   
      public class StatusClosed : SystemException
      {
         public StatusClosed(string message = "This account is closed,The operations failed.") : base(message)
         {

         }
      }
   
}
