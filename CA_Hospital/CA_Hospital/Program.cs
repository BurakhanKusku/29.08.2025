using CA_Hospital;

#region HospitalName
Console.Write("Kaç Adet Hastane Girişi Olacak : ");
int hospitalAdet = int.Parse(Console.ReadLine());

HospitalName[] hospitall = new HospitalName[hospitalAdet];

for (int i = 0; i < hospitalAdet; i++)
{
    try
    {
        HastaneBilgi(i);
    }
    catch
    {
        Console.WriteLine("HATA!!!");
    }
}

foreach (HospitalName hastane in hospitall)
{
    Console.WriteLine(hastane.hospitalName + " \n" + hastane.hospitalCity);
}

void HastaneBilgi(int index)
{
    HospitalName hospital = new HospitalName();
    Console.Write("Hospital Name: ");
    hospital.hospitalName = Console.ReadLine();

    Console.Write("Hospital City: ");
    hospital.hospitalCity = Console.ReadLine();

    hospitall[index] = hospital;
}
#endregion


#region Departments

Console.Write("Kaç Adet Departman Girişi Olacak: ");
int departmanAdet = int.Parse(Console.ReadLine());

Departments[] departman = new Departments[departmanAdet]; 

for(int i = 0; i < departmanAdet; i++)
{
    try
    {
        Departman(i);
    }
    catch (Exception)
    {
        Console.WriteLine("DEPARTMAN HATA !!");
    }
}

foreach (Departments depar in departman)
{
    Console.WriteLine(depar.deparmentName);
}

void Departman(int inx)
{
    Departments departments = new Departments();
    Console.Write("Departman Adı: ");
    departments.deparmentName = Console.ReadLine();

    departman[inx] = departments;
}



#endregion


#region PatientRegistration

Console.Write("Kaç Adet Hasta Girişi Olacak : ");
int hastaAdet = int.Parse(Console.ReadLine());

PatientRegistration [] patient = new PatientRegistration[hastaAdet];

for (int i = 0; i < hastaAdet; i++)
{
    try
    {
        HastaBilgi(i);
    }
    catch
    {
        Console.WriteLine("HATA!!!");
    }
}

foreach (PatientRegistration hasta in patient)
{
    Console.WriteLine(hasta.firstName + " \n" + hasta.lastName + " \n" + hasta.gender + " \n" + hasta.age + " \n" + hasta.disease);
}

void HastaBilgi(int index)
{
    PatientRegistration hasta = new PatientRegistration();
    Console.Write("Adı: ");
    hasta.firstName = Console.ReadLine();

    Console.Write("Soyadı: ");
    hasta.lastName = Console.ReadLine();

    Console.Write("Cinsiyet: ");
    hasta.gender = Console.ReadLine();

    Console.Write("Yaş: ");
    hasta.age = int.Parse(Console.ReadLine());

    Console.Write("Hastalık: ");
    hasta.disease = Console.ReadLine();

    patient[index] = hasta;
}


#endregion


#region Nurses

Console.Write("Kaç Adet Hemşire Girişi Olacak : ");
int hemsireAdet = int.Parse(Console.ReadLine());

Nurses[] hemsirem = new Nurses[hemsireAdet];

for (int i = 0; i < hemsireAdet; i++)
{
    try
    {
        HemsireBilgi(i);
    }
    catch
    {
        Console.WriteLine("HATA!!!");
    }
}

foreach (Nurses hemsir in hemsirem)
{
    Console.WriteLine(hemsir.name + " \n" + hemsir.surname);
}

void HemsireBilgi(int index)
{
    Nurses hemsire = new Nurses();
    Console.Write("Hemşire Adı: ");
    hemsire.name = Console.ReadLine();

    Console.Write("Hemşire Soyadı: ");
    hemsire.surname = Console.ReadLine();

    hemsirem[index] = hemsire;
}
#endregion

#region Doctors
Console.Write("Kaç Adet Doktor Girişi Olacak : ");
int doktorAdet = int.Parse(Console.ReadLine());

Doctors[] doktorlar = new Doctors[doktorAdet];

for (int i = 0; i < doktorAdet; i++)
{
    try
    {
        DoktorBilgi(i);
    }
    catch
    {
        Console.WriteLine("HATA!!!");
    }
}

foreach (Doctors doktor in doktorlar)
{
    Console.WriteLine(doktor.doctorName + " \n" + doktor.doctorLastName + " \n" + doktor.reputation);
}

void DoktorBilgi(int index)
{
    Doctors doktor = new Doctors();
    Console.Write("Doktor Adı: ");
    doktor.doctorName = Console.ReadLine();

    Console.Write("Doktor Soy Adı: ");
    doktor.doctorLastName = Console.ReadLine();

    Console.Write("Doktor Ünvanı: ");
    doktor.reputation = Console.ReadLine();

    doktorlar[index] = doktor;
}



#endregion