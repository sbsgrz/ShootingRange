/*
 * Events
 * Menu
 * CheckList - requirements
 * Tests
 */

using ShootingRange;


ShooterInMemory shooterIM = new ShooterInMemory("John","Fleeting");
ShooterSaved shooterS = new ShooterSaved("Mary","NonVolatile");

void ShooterResultAdded(object sender, EventArgs e)
{
    Console.WriteLine($"The result has been added. {sender.ToString()}");
}

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
    else
    {
        try
        {
                shooterIM.AddResult(input);
                shooterS.AddResult(input);
        }
        catch(Exception ex)
        {
            // Console.WriteLine(ex.ToString());
            // Console.WriteLine();
            Console.WriteLine($"{ex.Source}:  {ex.Message}");
        }
    }
}

Statistics shooterIMStatistics = shooterIM.GetStatistics();
Statistics shooterSStatistics = shooterS.GetStatistics();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"{shooterIM.firstName} {shooterIM.lastName}");
Console.WriteLine($"General score: {shooterIMStatistics.Sum}");
Console.WriteLine($"Average score: {shooterIMStatistics.Avg}");
Console.WriteLine($"Number of shots fired: {shooterIMStatistics.Count}");
Console.WriteLine($"Focus on the shield: {shooterIMStatistics.focusOnTheShield}");
Console.WriteLine($"Max: {shooterIMStatistics.Max}");
Console.WriteLine($"Min: {shooterIMStatistics.Min}");
Console.WriteLine();

Console.WriteLine($"{shooterS.firstName} {shooterS.lastName}");
Console.WriteLine($"General score: {shooterSStatistics.Sum}");
Console.WriteLine($"Average score: {shooterSStatistics.Avg}");
Console.WriteLine($"Number of shots fired: {shooterSStatistics.Count}");
Console.WriteLine($"Focus on the shield: {shooterSStatistics.focusOnTheShield}");
Console.WriteLine($"Max: {shooterSStatistics.Max}");
Console.WriteLine($"Min: {shooterSStatistics.Min}");


Console.ReadLine();
