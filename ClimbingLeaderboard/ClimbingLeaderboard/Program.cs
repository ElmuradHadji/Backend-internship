Console.WriteLine("Liderlikdə olan oyunçu sayını daxil edin");
int LeaderBoardCount = int.Parse(Console.ReadLine());
while (LeaderBoardCount < 1)
{
    Console.WriteLine("oyunçu sayını düzgün daxil etdiyinizdən əmin olun");
    LeaderBoardCount = int.Parse(Console.ReadLine());
}
while (LeaderBoardCount > 2*Math.Pow(10,5))
{
    Console.WriteLine("oyunçu sayı 200000dən çox ola bilməz!");
    LeaderBoardCount = int.Parse(Console.ReadLine());
}
int[] LeaderBoardPoints= new int[LeaderBoardCount];
for (int i = 0; i < LeaderBoardCount; i++)
{
    Console.WriteLine((i+1)+"Oyunçunun balını daxil edin");
    int Point= int.Parse(Console.ReadLine());
    LeaderBoardPoints[i] = Point;
}

Console.WriteLine("Keçirilən Oyun sayını daxil edin");
int GameCount = int.Parse(Console.ReadLine());
while (GameCount < 1)
{
    Console.WriteLine("oyun sayını düzgün daxil etdiyinizdən əmin olun");
    GameCount = int.Parse(Console.ReadLine());
}
while (LeaderBoardCount > 2 * Math.Pow(10, 5))
{
    Console.WriteLine("oyun sayı 200000dən çox ola bilməz!");
    LeaderBoardCount = int.Parse(Console.ReadLine());
}
int[] Player = new int[GameCount];
for (int i = 0; i < GameCount; i++)
{
    Console.WriteLine((i + 1) + "Oyunçunun balını daxil edin");
    int Point = int.Parse(Console.ReadLine());
    Player[i] = Point;
}
int PlayerResult=0;
int Rank = LeaderBoardCount+1;

int[] NewLeaderBoardPoints = new int[Rank];

for (int i = 0;i<Player.Length;i++)
{
    PlayerResult += Player[i];
    for (int j = 0; j < NewLeaderBoardPoints.Length; j++)
    {
        if (PlayerResult > LeaderBoardPoints[j])
        {
            Rank--;
        }

    }
}
//Deadline az qaldığından Bu məsələ optimallaşdırlmayıb xahiş edirəm nəzərə alasınız