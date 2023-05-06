using System.Net.NetworkInformation;

namespace ShootingRange.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var s = new ShooterInMemory();
            var st = new Statistics();

            
            
            Assert.Pass(); 
        }
    }
}