using csharp_ecommerce_db;

using (EcommerceContext db = new EcommerceContext())
{
    //Product mouse = new Product("mouse", 13.99m, "un gran bel mouse");
    //Product tastiera = new Product("tastiera", 18.99m, "una gran bella tastiera");
    //Product monitor = new Product("monitor", 150.49m, "un gran bel monitor");

    //db.Add(mouse);
    //db.Add(tastiera);
    //db.Add(monitor);
    //db.SaveChanges();


    Customer marco = new Customer("Marco", "Rossi", "marcorossi@mail.com");
    Customer sara = new Customer("Sara", "Bianchi", "sarabianchi@mail.com");

    db.Add(marco);
    db.Add(sara);
    db.SaveChanges();


    Order order1 = new Order(1, DateTime.Now, "succesfull", sara);
    Order order2 = new Order(3, DateTime.Now, "succesfull", sara);
    Order order3 = new Order(1, DateTime.Now, "succesfull", marco);
    Order order4 = new Order(1, DateTime.Now, "succesfull", sara);
    Order order5 = new Order(1, DateTime.Now, "succesfull", marco);



}
