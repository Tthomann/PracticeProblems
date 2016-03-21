using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Problem4
    {
        List<int> BeginNumbers = new List<int> { 1, 2, 3 };

        List<int> EndNumbers = new List<int>();
        public Problem4()
        {

        }
        public void CycleNumbers()
        {
            EndNumbers.Add(BeginNumbers[0]);
            EndNumbers.Add(BeginNumbers[2]);
            EndNumbers.Add(BeginNumbers[1]);
   

            for(int i = 0; i < EndNumbers.Count; i ++)
            {
                Console.WriteLine(EndNumbers[i] + 5);
                Console.ReadLine();
            }
        }
    }
}
