using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        public   int Id { get; set; }
        public String UserName { get; set; }

        // Full Implementation of above short hand implementation
        /* private int myVar;
         public int MyProperty
         {
             get { return myVar; }
             set { myVar = value; }
         }*/
        
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}