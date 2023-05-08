
namespace ShootingRange
{
    public interface IShooter
    {
        public string FirstName { get; }
        public string LastName { get; }

        void AddResult(int result);
        void AddResult(float result);
        void AddResult(string result);
        void AddResult(double result);
        void AddResult(char result);
        List<int> GetResults();
        Statistics GetStatistics();
    }
}
