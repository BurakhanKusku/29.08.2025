using CA_Computers;

Islemci islemci = new Islemci();
islemci.marka = "Intel";
islemci.model = "I9";
islemci.fiyat = 21000;

Ram ram = new Ram();
ram.marka = "Kingston";
ram.model = "xyz";
ram.fiyat = 4000;
ram.kapasite = "64";

EkranKart ekranKart = new EkranKart();
ekranKart.marka = "Nvidia";
ekranKart.model = "4090ti";
ekranKart.fiyat = 19800;


Bilgisayar bilgisayar = new Bilgisayar();
bilgisayar.ram = ram;
bilgisayar.ekrankart = ekranKart;
bilgisayar.islemci = islemci;

Console.WriteLine(bilgisayar.islemci.marka + " " + bilgisayar.ram.marka + " " + bilgisayar.ekrankart.marka);