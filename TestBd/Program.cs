using System;
using System.Linq;

namespace TestBd
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestContext())
            {
                var date=new DateTime(2015,12,31);
                var users = db.Accounts.Where(x => x.CreateOn > date);
                if(users.Count()!=0)
                    foreach (var item in users)
                    {
                        Console.WriteLine(item.Name);
                    }
                    
            }
        }
    }
}
