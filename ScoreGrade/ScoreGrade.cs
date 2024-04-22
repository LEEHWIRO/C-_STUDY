
class ScoreGrade
{
    static void Main()
    {
        int score = 0;
        char grade = 'F';

        Console.WriteLine("당신의 점수는? ");
        score = Convert.ToInt32(Console.ReadLine());

        if (score >= 90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else
        {
            grade = 'F';
        }

        Console.WriteLine($"점수 : {score}점");
        Console.WriteLine($"등급 : {grade}점");
    }
}