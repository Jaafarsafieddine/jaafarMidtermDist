// See https://aka.ms/new-console-template for more information
using Advanced_lab1;
using Newtonsoft.Json;
using System.Xml.Linq;


/*Car a = new Car();
a.make = "ferraiari";
a.speed = 350;
Console.WriteLine(a.make+" "+a.speed);
Product product = new Product();
product.Name = "Apple";
product.ExpiryDate = new DateTime(2008, 12, 28);
product.price = 3.99;
product.size = new string[] { "small", "medium", "large" };

string output = JsonConvert.SerializeObject(product);

//Console.WriteLine(output);

Product deserializeProduct = JsonConvert.DeserializeObject<Product>(output);
Console.WriteLine(deserializeProduct.Name + " " + deserializeProduct.ExpiryDate);
*/

string product = @"{
    ""colors"": [
        {
            ""color"": ""black"",
            ""category"": ""hue"",
            ""type"": ""primary"",
            ""code"": {
                ""rgba"": [255, 255, 255, 1],
                ""hex"": ""#000""
            }
        },
        {
            ""color"": ""white"",
            ""category"": ""value"",
            ""code"": {
                ""rgba"": [0, 0, 0, 1],
                ""hex"": ""#FFF""
            }
        },
        {
            ""color"": ""red"",
            ""category"": ""hue"",
            ""type"": ""primary"",
            ""code"": {
                ""rgba"": [255, 0, 0, 1],
                ""hex"": ""#FF0""
            }
        },
        {
            ""color"": ""blue"",
            ""category"": ""hue"",
            ""type"": ""primary"",
            ""code"": {
                ""rgba"": [0, 0, 255, 1],
                ""hex"": ""#00F""
            }
        },
        {
            ""color"": ""yellow"",
            ""category"": ""hue"",
            ""type"": ""primary"",
            ""code"": {
                ""rgba"": [255, 255, 0, 1],
                ""hex"": ""#FF0""
            }
        },
        {
            ""color"": ""green"",
            ""category"": ""hue"",
            ""type"": ""secondary"",
            ""code"": {
                ""rgba"": [0, 255, 0, 1],
                ""hex"": ""#0F0""
            }
        }
    ]
}";

ColorList deserializeProduct = JsonConvert.DeserializeObject<ColorList>(product);
Color Newadd = new Color();
Newadd.type = "primary";
Newadd.color = "orange";
Newadd.type = "primary";


Code Newcode = new Code();
Newcode.rgba = [0, 255, 255, 0];
Newcode.hex = "#0ff01";

Newadd.code = Newcode;

deserializeProduct.colors.Add(Newadd);
foreach (var color in deserializeProduct.colors)
{
  //  Console.WriteLine(color.code.rgba);
    Console.WriteLine(color.color + ": " + string.Join(", ", color.code.rgba));
}

Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();
foreach (var color in deserializeProduct.colors)
{
    if (color.type=="primary")
    {
        Console.WriteLine(color.color + ": " + string.Join(", ", color.code.rgba));
    }
    
}
Console.WriteLine();
Console.WriteLine("---------------------------------");
Console.WriteLine();
String input = null;

while (string.IsNullOrEmpty(input))
{
    Console.WriteLine("Enter the hex code you want to search for");
    input = Console.ReadLine();
}

foreach (var color in deserializeProduct.colors)
{
    if (color.code.hex.ToLower() == input.ToLower())
    {
        Console.WriteLine(color.color + ": " + string.Join(", ", color.code.rgba));
    }

}


