using CA_Shoes;

Shoes shoes = new Shoes(); //instance
int i = 1;
Shoes[] shoes1 = new Shoes[i];

while (i > 0)
{
    try
    {

        Shoess();

    }
    catch
    {
        Console.WriteLine("Hata meydana geldi!");
    }
    i--;
}

foreach (Shoes ayakkabi in shoes1)
{
    Console.WriteLine($"\nMarka: {ayakkabi.marka}\nModel: {ayakkabi.model}\nRenk: {ayakkabi.renk}\nTür: {ayakkabi.tur}\nCinsiyet: {ayakkabi.cinsiyet} \nNumara: {ayakkabi.numara}\nFiyat: {ayakkabi.fiyat}");
}


void Shoess()
{
    Console.Write("Marka: ");
    shoes.marka = Console.ReadLine();
    Console.Write("Model: ");
    shoes.model = Console.ReadLine();
    Console.Write("Tür: ");
    shoes.tur = Console.ReadLine();
    Console.Write("Renk: ");
    shoes.renk = Console.ReadLine();
    Console.Write("Cinsiyet: ");
    shoes.cinsiyet = Console.ReadLine();
    Console.Write("Numara: ");
    shoes.numara = int.Parse(Console.ReadLine());
    Console.Write("Fiyat: ");
    shoes.fiyat = decimal.Parse(Console.ReadLine());

    shoes1[i - 1] = shoes;
}

Console.Read();