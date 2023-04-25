using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingRange 
{
    public class ShooterInMemory : ShooterBase
    {
        private List<int> results = new List<int>();
        public override void AddResult(int result)
        {
            if ((result >= 1) && (result <= 10))
                this.results.Add(result);
            else
                throw new Exception("Parameter out of range.");
        }
    }
}
