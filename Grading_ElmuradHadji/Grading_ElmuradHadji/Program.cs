Console.WriteLine("Tələbə sayını daxil edin:");
int StudentCount = int.Parse(Console.ReadLine());
while (StudentCount > 60)
{
    Console.WriteLine("Max tələbə sayı 60dır. Sayı Təkrar daxil edin:");
    StudentCount = int.Parse(Console.ReadLine());

}
int[] Grades = new int[StudentCount];
for (int i = 0; i < StudentCount; i++)
{
    Console.WriteLine((i + 1) + " tələbənin qiymətini daxil edin:");
    int grade = int.Parse(Console.ReadLine());
    while (grade < 0 || grade > 100)
   
        {
            Console.WriteLine("Məlumatları düzgün daxil etdiyinizdən əmin olun");
            grade = int.Parse(Console.ReadLine());
        };
    Grades[i] = grade;
}
Console.WriteLine($"Tələbə     Əsl Qiymət          Yuvarlaq Forma ");
for (int i = 0; i < Grades.Length; i++)
{


    int RoundedGrade = Grades[i];

    int RoundingPoint = 5 * (int)Math.Ceiling((decimal)Grades[i] / 5);
    Console.WriteLine(RoundingPoint);
    if (RoundingPoint - Grades[i] < 3)
    {
        RoundedGrade = RoundingPoint;
    }
    if (RoundedGrade < 40)
    {
        Console.WriteLine("Tələbə" + (i + 1) + ": " + Grades[i] + "    " + RoundedGrade + "     FAILED ");
        continue;


    }
    Console.WriteLine("Tələbə" + (i + 1) + ": " + Grades[i] + "    " + RoundedGrade);
}
