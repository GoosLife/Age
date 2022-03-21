string name, input;
byte age;

Console.WriteLine("Indtast dit navn: ");
name = Console.ReadLine();

do
{
    Console.WriteLine("Indtast din alder: ");
    input = Console.ReadLine();
}
while (!byte.TryParse(input, out age));

if (age < 3) // age < 3
{
    Console.WriteLine($"{name}, du må gå med ble.");
}
else if (age > 3 && age <= 15) // Age between 3 and 15
{
    Console.WriteLine($"{name}, du må ingenting.");
}
else if (age > 15 && age < 18) // Age between 15 and 18 (15 and 18 excluded)
{
    Console.WriteLine($"{name}, du må drikke.");
}
else // Age 18 and above
{
    Console.WriteLine($"{name}, du må stemme og køre bil.");
}