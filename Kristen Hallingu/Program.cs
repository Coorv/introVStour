int a_külg = 0;
int b_külg = 0;
int c_külg = 0;
int diameeter = 0;
string Kujund = "";

Console.WriteLine("Kas sinu tuba on kolmnurga, ristküliku või ringi kujuline?");
Kujund = Console.ReadLine();
if (Kujund == "kolmnurk")
{
    Console.WriteLine("palun sisesta oma toa esimene külg");
    a_külg = int.Parse(Console.ReadLine());
    Console.WriteLine("palun sisesta oma toa teine külg");
    b_külg = int.Parse(Console.ReadLine());
    Console.WriteLine("palun sisesta oma toa kolmas külg");
    c_külg= int.Parse(Console.ReadLine());
    int tehe = (a_külg +b_külg + c_külg) / 2;
    Console.WriteLine($"Tehte tulemus: {tehe}");
}

