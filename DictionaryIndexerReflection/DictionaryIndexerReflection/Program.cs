// See https://aka.ms/new-console-template for more information

using Domain.Models;

Shop shop = new(10);
shop[0] = new Product()
{
    Id = 1,
    Name = "Medicine",
    Count=10
};
shop[1] = new Product()
{
    Id = 2,
    Name = "Phone",
    Count = 12
};
shop[2] = new Product()
{
    Id = 3,
    Name = "Sweets",
    Count = 13
};
shop[12] = new Product() 
{ 
    Id = 13, 
    Name = "Bomb",
    Count = 1 
};
foreach(var item in )
{
    Console.WriteLine(item);
}
Console.WriteLine(shop[0].Name);
