using ShootingRange;

static void ShooterResultAdded(object sender, EventArgs e)
{
    Console.WriteLine($"The result has been added. {sender.ToString()}");
}

ShooterInMemory shooterIM = new ShooterInMemory("John","Fleeting");
ShooterSaved shooterS = new ShooterSaved("Mary","NonVolatile");

shooterIM.ResultAdded+= ShooterResultAdded;
shooterS.ResultAdded+= ShooterResultAdded;

Console.WriteLine("Hello! Provide your results! (q - finishes entering)");

while (true)
{
    Console.Write("Enter a value: ");

    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    else if (input != null)
    {
        try
        {
                shooterIM.AddResult(input);
                shooterS.AddResult(input);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"{ex.Source}:  {ex.Message}");
        }
    }
}

Statistics shooterIMStatistics = shooterIM.GetStatistics();
Statistics shooterSStatistics = shooterS.GetStatistics();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{shooterIM.FirstName} {shooterIM.LastName}");
if (shooterIMStatistics.Count > 0)
{
    Console.WriteLine($"General score: {shooterIMStatistics.Sum}");
    Console.WriteLine($"Average score: {shooterIMStatistics.Avg}");
    Console.WriteLine($"Number of shots fired: {shooterIMStatistics.Count}");
    Console.WriteLine($"Focus on the shield: {shooterIMStatistics.FocusOnTheShield} (the lower the value, the better)");
    Console.WriteLine($"Max: {shooterIMStatistics.Max}");
    Console.WriteLine($"Min: {shooterIMStatistics.Min}");
}
else
{
    Console.WriteLine("No shot was fired.");
}
Console.WriteLine();

Console.WriteLine($"{shooterS.FirstName} {shooterS.LastName}");
if(shooterSStatistics.Count > 0)
{
    Console.WriteLine($"General score: {shooterSStatistics.Sum}");
    Console.WriteLine($"Average score: {shooterSStatistics.Avg}");
    Console.WriteLine($"Number of shots fired: {shooterSStatistics.Count}");
    Console.WriteLine($"Focus on the shield: {shooterSStatistics.FocusOnTheShield} (the lower the value, the better)");
    Console.WriteLine($"Max: {shooterSStatistics.Max}");
    Console.WriteLine($"Min: {shooterSStatistics.Min}");
}
else
{
    Console.WriteLine("No shot was fired");
}

Console.ReadLine();
