Console.WriteLine("Case Sayını daxil edin");
int CaseCount = int.Parse(Console.ReadLine());
while (CaseCount < 1)
{
    Console.WriteLine("Case sayını düzgün daxil etdiyinizdən əmin olun");
    CaseCount = int.Parse(Console.ReadLine());
}
while (CaseCount > 100)
{
    Console.WriteLine("Case sayı 100dən çox ola bilməz!");
    CaseCount = int.Parse(Console.ReadLine());
}
for (int i = 0; i < CaseCount; i++)
{
    Console.WriteLine("Məhbus sayını  daxil edin");
    int PrisonerCount = int.Parse(Console.ReadLine());
    while (PrisonerCount < 1)
    {
        Console.WriteLine("Məhbus sayını düzgün daxil etdiyinizdən əmin olun");
        PrisonerCount = int.Parse(Console.ReadLine());
    }
    while (PrisonerCount >= Math.Pow(10, 9))
    {
        Console.WriteLine("Məhbus sayını 1000000000dən çox ola bilməz!");
        PrisonerCount = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Şirniyyat sayını  daxil edin");
    int SweetCount = int.Parse(Console.ReadLine());
    while (SweetCount < 1)
    {
        Console.WriteLine("Şirniyyat sayını düzgün daxil etdiyinizdən əmin olun");
        SweetCount = int.Parse(Console.ReadLine());
    }
    while (SweetCount >= Math.Pow(10, 9))
    {
        Console.WriteLine("Şirniyyat sayını 1000000000dən çox ola bilməz!");
        SweetCount = int.Parse(Console.ReadLine());
    }




    Console.WriteLine("Başlanğıc oturacaq nömrəsini  daxil edin");
    int StartChairNum = int.Parse(Console.ReadLine());
    while (StartChairNum < 1)
    {
        Console.WriteLine("Başlanğıc oturacaq nömrəsini düzgün daxil etdiyinizdən əmin olun");
        StartChairNum = int.Parse(Console.ReadLine());
    }
    while (StartChairNum > PrisonerCount)
    {
        Console.WriteLine("Başlanğıc oturacaq nömrəsi Məhbus sayından çox ola bilməz!");
        StartChairNum = int.Parse(Console.ReadLine());
    }



    int step = SweetCount % PrisonerCount;
    StartChairNum += step-1;
    if (StartChairNum>PrisonerCount)
    {
        StartChairNum -= PrisonerCount;
    }

   

    Console.WriteLine("Nəticə: " + StartChairNum);
}