

namespace ShootingRange
{
    public abstract class ShooterBase : IShooter
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }

        public ShooterBase()
        {
            this.firstName = string.Empty;
            this.lastName = string.Empty;
        }

        public ShooterBase(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public abstract void AddResult(int result);

        public void AddResult(float result)
        {
            throw new NotImplementedException();
        }

        public void AddResult(string result)
        {
            throw new NotImplementedException();
        }

        public void AddResult(double result)
        {
            throw new NotImplementedException();
        }

        public void AddResult(char result)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }
    }
}
