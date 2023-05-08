using System.Security.Cryptography.X509Certificates;

namespace ShootingRange
{
    public class ShooterSaved : ShooterBase
    {
        public const string FileName = "results.txt";
        public override event ResultAddedDelegate? ResultAdded;
        
        public ShooterSaved() : base() { }
        
        public ShooterSaved(string firstName, string lastName) : base(firstName, lastName) { }

        public override void AddResult(int result)
        {
            if ((result <= Max) && (result >= Min))
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(result);
                    if (ResultAdded != null)
                        ResultAdded(this, new EventArgs());
                }
            }
            else
                throw new Exception("Parameter out of range");
        }

        public override List<int> GetResults()
        {
            List<int> results = new List<int>();
            
            using (var reader = File.OpenText(FileName))
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
