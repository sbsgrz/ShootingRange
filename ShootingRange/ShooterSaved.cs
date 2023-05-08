using System.Security.Cryptography.X509Certificates;

namespace ShootingRange
{
    public class ShooterSaved : ShooterBase
    {
        public const string FileName = "results.txt";
        public override event ResultAddedDelegate? ResultAdded;
        
        public ShooterSaved() : base() { }
        
        public ShooterSaved(string firstName, string lastName) : base(firstName, lastName) { }

        public override void AddResult(float result)
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

        public override List<float> GetResults()
        {
            List<float> results = new List<float>();
            
            using (var reader = File.OpenText(FileName))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    results.Add(float.Parse(line));
                    line = reader.ReadLine();
                }
            }
            return results;
        }
    }
}
