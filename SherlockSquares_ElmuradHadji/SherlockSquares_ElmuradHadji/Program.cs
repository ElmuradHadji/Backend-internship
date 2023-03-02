Console.WriteLine("Case Sayını daxil edin");
int CaseCount=int.Parse(Console.ReadLine());
while (CaseCount<1)
{
    Console.WriteLine("Case sayını düzgün daxil etdiyinizdən əmin olun");
    CaseCount=int.Parse(Console.ReadLine());
}
while (CaseCount >100)
{
    Console.WriteLine("Case sayı 100dən çox ola bilməz!");
    CaseCount = int.Parse(Console.ReadLine());
}
for (int i = 0; i < CaseCount; i++)
{
    Console.WriteLine("Başlanğıc nöqtəni  daxil edin");
    int StartPoint = int.Parse(Console.ReadLine());
    while (StartPoint < 1)
    {
        Console.WriteLine("Başlanğıc nöqtəni düzgün daxil etdiyinizdən əmin olun");
        StartPoint = int.Parse(Console.ReadLine());
    }
    while (StartPoint >= Math.Pow(10, 9))
    {
        Console.WriteLine("Başlanğıc nöqtəni 1000000000dən çox ola bilməz!");
        StartPoint = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Son nöqtəni  daxil edin");
    int EndPoint = int.Parse(Console.ReadLine());
    while (EndPoint < 1)
    {
        Console.WriteLine("Son nöqtəni düzgün daxil etdiyinizdən əmin olun");
        EndPoint = int.Parse(Console.ReadLine());
    }
    while (EndPoint >= Math.Pow(10, 9))
    {
        Console.WriteLine("Son nöqtəni 1000000000dən çox ola bilməz!");
        EndPoint = int.Parse(Console.ReadLine());
    }
    while (EndPoint < StartPoint)
    {
        Console.WriteLine("Son nöqtə Başlanğıc nöqtədən kiçik ola bilməz !");
        EndPoint = int.Parse(Console.ReadLine());
    }
        int SquareNumberCount = 0;
        if (StartPoint==1)
        {
            SquareNumberCount++;
        }
    for (int j = StartPoint; j <= EndPoint; j++)
    {
        for (int k = 1; k <= j/2; k++)
        {
            if (k*k==j)
            {
                SquareNumberCount++;

            }
        }
    }
        Console.WriteLine("Nəticə: "+SquareNumberCount);
}