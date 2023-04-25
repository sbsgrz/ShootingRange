

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
            Console.WriteLine(ex.ToString());
            Console.WriteLine();
            Console.WriteLine(ex.Message);
        }
    }
}