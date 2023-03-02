Console.WriteLine("Şam sayını daxil edin:");
int CandleCount = int.Parse(Console.ReadLine());
while (CandleCount<0||CandleCount > Math.Pow(10,5))
{
    Console.WriteLine($"Max Şam sayı: {Math.Pow(10, 5)}. Sayı Təkrar daxil edin:");
    CandleCount = int.Parse(Console.ReadLine());

}
int[] Candles = new int[CandleCount];
for (int i = 0; i < CandleCount; i++)
{
    Console.WriteLine((i + 1) + " Şamın hündürlüyünü daxil edin:");
    int height = int.Parse(Console.ReadLine());
    while (height < 0 || height > Math.Pow(10,7))

    {
        Console.WriteLine("Məlumatları düzgün daxil etdiyinizdən əmin olun");
        height = int.Parse(Console.ReadLine());
    };
    Candles[i] = height;
}
int Count = 0;
int Max =Candles[0];
for (int i = 1; i < Candles.Length; i++)
{
    if (Candles[i]>Max)
    {
        Max = Candles[i];
    }
}


foreach (var item in Candles)
{
    if (item==Max)
    {
        Count++;
    }
}
Console.WriteLine("Result: " + Count);