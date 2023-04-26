

using ShootingRange;

ShooterInMemory shooterIM = new ShooterInMemory();

while(true)
{
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    else
    {
        try
        {
                shooterIM.AddResult(input);
        }
        catch(Exception ex)
        {
            // Console.WriteLine(ex.ToString());
            // Console.WriteLine();
            Console.WriteLine(ex.Message);
        }
    }
}

Statistics shooterIMStatistics = shooterIM.GetStatistics();

Console.WriteLine($"General score: {shooterIMStatistics.Sum}");
Console.WriteLine($"Average score: {shooterIMStatistics.Avg}");
Console.WriteLine($"Number of shots fired: {shooterIMStatistics.Count}");
Console.WriteLine($"Focus on the shield: {shooterIMStatistics.focusOnTheShield}");
Console.WriteLine($"Max: {shooterIMStatistics.Max}");
Console.WriteLine($"Min: {shooterIMStatistics.Min}");




Console.ReadLine();