using System;

using System.Data.Entity;




class Napis

{
    public int ID { get; set; }
    public string napis { get; set; }
}

class DbConection : DbContext
{
    public DbConection() : base(@"Data Source=(local)\MYINSTANCE;Initial Catalog=MyTestDB;Integrated Security=True") { }
    public DbSet<Napis> Napis { get; set; } 
}

class MainClass

{
    class Program
    {
        static void Main()
        {
            var txt = new Napis
            {
                napis = Convert.ToString(Console.ReadLine())
            };
            var dbConection = new DbConection();
            dbConection.Napis.Add(txt);
            dbConection.SaveChanges();
 
        }
    }
}
