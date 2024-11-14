using DataBase_Advanced;

Console.WriteLine("Hello, World!");
DataContext dc = new DataContext();
Person person1 = new Person { Name = "jaafar", Age = 22 };
Person person2 = new Person { Name = "saf", Age = 27 };
Person person3 = new Person { Name = "lbne", Age = 30 };
//var res = dc.Persons.Find(1);
//dc.Persons.Remove(dc.Persons.Find(3));
//dc.SaveChanges();
//Console.WriteLine(res.Name);
//var res = dc.Persons;
//foreach( var a in res)
//{
//    Console.WriteLine(a.Name);
//}
