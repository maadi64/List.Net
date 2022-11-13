using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice1
{
    public class AccountInfo : IEquatable<AccountInfo>
    {
        public string AccountName { get; set; }

        public int ClientId { get; set; }

        public override string ToString()
        {
            return "ID: " + ClientId + "   Name: " + AccountName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            AccountInfo objAsAccount = obj as AccountInfo;
            if (objAsAccount == null) return false;
            else return Equals(objAsAccount);
        }
        public override int GetHashCode()
        {
            return ClientId;
        }
        public bool Equals(AccountInfo other)
        {
            if (other == null) return false;
            return (this.ClientId.Equals(other.ClientId));
        }
        // Should also override == and != operators.
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<AccountInfo> Account = new List<AccountInfo>();
            Account.Add(new AccountInfo { ClientId = 123, AccountName = "Ammad" });
            Account.Add(new AccountInfo { ClientId = 234, AccountName = "Ali" });
            Account.Add(new AccountInfo { ClientId = 2234, AccountName = "AliJamsehad" });
            foreach (var Account1 in Account)
            {
                Console.WriteLine(Account1);

            }
            //inserting at position 2 
            Console.WriteLine("Inserting at Position 2");
            Account.Insert(2, new AccountInfo { AccountName = "Haider Ali ", ClientId = 123 });
            foreach (var Account1 in Account)
            {
                Console.WriteLine(Account1);

            }
            Console.WriteLine("removing from the List");
            // This will remove part 1534 even though the PartName is different,
            // because the Equals method only checks PartId for equality
            Account.Remove(new AccountInfo { AccountName = "JAANU", ClientId = 123 });
            foreach (var Account1 in Account)
            {
                Console.WriteLine(Account1);
            }
            //removing at Position3 
            
            Console.WriteLine("removing at position 3");
            Account.RemoveAt(3);
            foreach (var Account1 in Account)
            {
                Console.WriteLine(Account1);
            }
            Console.ReadLine();
        }
    }
        
           

        
    
}
