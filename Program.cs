// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// db allo stato iniziale -->  dotnet ef database update 0
// dotnet ef migrations remove

using (EcommerceContext db = new EcommerceContext())
{
    // Creo tre prodotti 
    //Product product1 = new Product { Name = "Phon", Description = "Potentissimo phon", Price = 350 };
    //db.Add(product1);

    //Product product2 = new Product { Name = "Piastra", Description = "Bellisima piastra", Price = 250.50 };
    //db.Add(product2);

    //Product product3 = new Product { Name = "Ferro", Description = "Fanastici boccoli", Price = 150 };
    //db.Add(product3);
    //db.SaveChanges();
}
