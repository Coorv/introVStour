int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / * ^^");
string tehtetüüp = Console.ReadLine();
int tehe = 0;

if (tehtetüüp == "+"  /*tingimus siia*/)
{ 
    tehe = arv1 + arv2;
}

if (tehtetüüp == "-")
{
    tehe = arv1 - arv2;
}

if (tehtetüüp == "*")
{
    tehe = arv1 * arv2;
}

if (tehtetüüp == "/")
{
    tehe = arv1 / arv2;
}

if (tehtetüüp == "^^")
{
    tehe = (int)Math.Pow(arv1, arv2);
}

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");
