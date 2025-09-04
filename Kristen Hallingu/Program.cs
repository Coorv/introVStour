/*
int käimatulevAasta = 2025;
int olenNiiVana = 560;
int tulemus = käimatulevAasta + olenNiiVana;

//float pikkus = 2.5f;

string sõnum = "Teie vanus on: ";

//bool miskion = false;
// CTRL K C
//Console.WriteLine(sõnum+tulemus);
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
//Console.WriteLine("oioioioioi");
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
//Console.WriteLine("sõnum");
*/

int arv1 = 0;
int arv2 = 0;
Console.WriteLine("Tere, palun sisesta esimene arv: ");
arv1 = int.Parse(Console.ReadLine());
Console.WriteLine("palun sisesta teine arv: ");
arv2 = int.Parse(Console.ReadLine());
Console.WriteLine("Missugust tehet soovid teha? Kirjuta kas: + - / *");
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

Console.WriteLine($"{tehtetüüp} Tehte tulemus: {tehe}");

//int lahutav1 = 0;
//int lahutav2 = 0;
//Console.WriteLine("Tere, palun sisesta esimene lahutav: ");
//lahutav1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine lahutav: ");
//lahutav2 = int.Parse(Console.ReadLine());
//int lahutamine = lahutav1 - lahutav2;
//Console.WriteLine($"Tehte tulemus: {lahutamine}");
//Console.WriteLine("Tehte tulemus: "+lahutamine);

//int jagatav = 0;
//int jagataja = 0;
//Console.WriteLine("Tere, palun sisesta esimene jagatav");
//jagatav = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine jagataja");
//jagataja = int.Parse(Console.ReadLine());
//int jagamine = jagatav / jagataja;
//Console.WriteLine($"Tehte tulemus: {jagamine}");
//Console.WriteLine("Tehte tulemus: " +jagamine);

//int korrutatav = 0;
//int korrutaja = 0;
//Console.WriteLine("Tere, palun sisesta esimene korrutatav");
//korrutatav = int.Parse(Console.ReadLine());
//Console.WriteLine("Tere, palun sisesta teine korrutaja");
//korrutaja = int.Parse(Console.ReadLine());
//int korrutamine = korrutatav * korrutaja;
//Console.WriteLine($"Tehte tulemus: {korrutamine}");
//Console.WriteLine("Tehte tulemus: " + korrutamine);

// + liitmine
// - lahutamine
// / jagamine
// * korrutamine

