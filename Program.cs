int i = 99;

while (i != 1)
{
    string bottles = i.ToString();
    Console.WriteLine("There's "+bottles+" bottles of beer on the wall");
    i = i - 1;
    Console.WriteLine("Take one down,");
}

if (i == 1)
{
    string bottle = i.ToString();
    Console.WriteLine("There's " + bottle + " bottle of beer on the wall");
}
