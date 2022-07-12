using csharp_ecommerce_db;

using (EcommerceContext db = new EcommerceContext())
{
    Product mouse = new Product("mouse", 13.99m, "un gran bel mouse");
    Product tastiera = new Product("tastiera", 18.99m, "una gran bella tastiera");
    Product monitor = new Product("monitor", 150.49m, "un gran bel monitor");

    //db.Add(mouse);
    //db.Add(tastiera);
    //db.Add(monitor);
    //db.SaveChanges();


    Customer marco = new Customer("Marco", "Rossi", "marcorossi@mail.com");
    Customer sara = new Customer("Sara", "Bianchi", "sarabianchi@mail.com");

    //db.Add(marco);
    //db.Add(sara);
    //db.SaveChanges();


    Order order1 = new Order(1, DateTime.Now, "succesfull", sara.Id);
    Order order2 = new Order(3, DateTime.Now, "succesfull", sara.Id);
    Order order3 = new Order(2, DateTime.Now, "succesfull", marco.Id);
    Order order4 = new Order(1, DateTime.Now, "succesfull", sara.Id);
    Order order5 = new Order(4, DateTime.Now, "succesfull", marco.Id);

    List<Order> ordersMarco = new List<Order>();
    ordersMarco.Add(order3);
    ordersMarco.Add(order5);
    marco.Orders = ordersMarco;

    List<Order> ordersSara = new List<Order>();
    ordersSara.Add(order1);
    ordersSara.Add(order2);
    ordersSara.Add(order4);
    ordersSara.Add(order5);
    sara.Orders = ordersSara;


    db.Add(order1);
    db.Add(order2);
    db.Add(order3);
    db.Add(order4);
    db.Add(order5);

    OrderProduct orderProduct1 = new OrderProduct(order1.Id, mouse.Id, 5);

    db.Add(orderProduct1);

    db.SaveChanges();



}
