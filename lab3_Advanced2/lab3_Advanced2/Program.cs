// See https://aka.ms/new-console-template for more information
using lab3_Advanced2;

/*
List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

var nameStartL = from frut in fruits where frut.StartsWith("L")  select frut;

foreach(string name in nameStartL)
{
    Console.WriteLine(name);
}

List<int> intlist = new List<int>() { 15,8,21,24,32,13,30,12,7,54,48,4,49,96};

var newNumber = intlist.Where(num => num % 4 == 0 && num % 6 == 0);

foreach(var num in newNumber)
{
    Console.WriteLine(num);
}

List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

Console.WriteLine(numbers.Count());

List<double> prices = new List<double>()
                {
                    879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
                };

double a = prices.Sum();
Console.WriteLine(a);
*/
Bankaccount bankAccount1 = new Bankaccount(1000, 123456789, "Bank of America");
Customer customer1 = new Customer("John Doe", bankAccount1);

Bankaccount bankAccount2 = new Bankaccount(1500, 987654321, "Chase Bank");
Customer customer2 = new Customer("Jane Smith", bankAccount2);

Bankaccount bankAccount3 = new Bankaccount(2000, 456789123, "Wells Fargo");
Customer customer3 = new Customer("Alice Johnson", bankAccount3);

List<Customer> customers = new List<Customer> { customer1, customer2, customer3 };

var customersByBank = customers.GroupBy(c => c.account.name);

foreach (var bankGroup in customersByBank)
{
    Console.WriteLine("Bank: " + bankGroup.Key);
    foreach (var customer in bankGroup)
    {
        Console.WriteLine("Customer: " + customer.name);
    }
}