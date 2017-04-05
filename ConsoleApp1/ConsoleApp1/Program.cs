using System;

class MainClass

{
    class Program
    {
        static void Main()
        {
            var txt = new Inscription
            {
                Text = Convert.ToString(Console.ReadLine())
            };
            var dbConection = new DbConection();
            dbConection.Inscription.Add(txt);
            dbConection.SaveChanges();
 
        }
    }
}
