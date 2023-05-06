using System.Security.Cryptography.X509Certificates;

namespace ShootingRange
{
    public class ShooterSaved : ShooterBase
    {
        public const string fileName = "results.txt";

        public override event ResultAddedDelegate? ResultAdded;

        public ShooterSaved() : base() { }

        public ShooterSaved(string firstName, string lastName) : base(firstName, lastName) { }

        

        public override void AddResult(int result)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(result);
                if(ResultAdded!= null)
                    ResultAdded(this, new EventArgs());
            }
        }

        public override List<int> GetResults()
        {
            List<int> results = new List<int>();
            using (var reader = File.OpenText(fileName))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    results.Add(int.Parse(line));
                    line = reader.ReadLine();
                }
            }
            return results;
        }
    }
}
