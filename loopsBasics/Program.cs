string stringCarrentScore = null;
int sum = 0;
int counter = 0;
int carrentScore;
do
{
    Console.WriteLine("Enter your students score. Enter -1 to finish!");

    stringCarrentScore = Console.ReadLine().Trim();
    if (int.TryParse(stringCarrentScore, out carrentScore))
    {
        if (carrentScore != -1)
        {
            sum += carrentScore;
            counter ++;
        }
    }
    else
    {
        Console.WriteLine("Enter the number correctly.");
    }
}
while (carrentScore != -1);

var average = sum / counter;

Console.WriteLine($"The average is: {average}");
Console.ReadKey();