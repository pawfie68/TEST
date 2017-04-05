using System.Data.Entity;

public class DbConection : DbContext
{
    public IDbSet<Inscription> Inscription { get; set; } 
} 
