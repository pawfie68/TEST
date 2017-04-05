using System;

using System.Data.Entity;

class DbConection : DbContext
{
    public DbConection() : base(@"Data Source=(local)\MYINSTANCE;Initial Catalog=MyTestDB;Integrated Security=True") { }
    public DbSet<Inscription> Inscription { get; set; } 
}

class MainClass

{
    class Program
    {
        static void Main()
        {
            var txt = new Inscription
            {
                inscription = Convert.ToString(Console.ReadLine())
            };
            var dbConection = new DbConection();
            dbConection.Inscription.Add(txt);
            dbConection.SaveChanges();
 
        }
    }
}
