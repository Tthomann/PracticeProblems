using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Problem3
    {
        List<string> ComboPattern = new List<string>();
        public Problem3()
        {

        }
        public void GoCombo()
        {
            ComboPattern.Add("UP");
            ComboPattern.Add("DOWN");
            ComboPattern.Add("LEFT");
            ComboPattern.Add("LEFT");
            ComboPattern.Add("RIGHT");
            ComboPattern.Add("RIGHT");
            ComboPattern.Add("DOWN");
            ComboPattern.Add("SPIN");
            ComboPattern.Add("DOWN");
            ComboPattern.Add("SPIN");
            ComboPattern.Add("DOWN");
            ComboPattern.Add("UP");
            ComboPattern.Add("LEFT");
            ComboPattern.Add("RIGHT");
            ComboPattern.Add("LEFT");
            ComboPattern.Add("DOWN");
            ComboPattern.Add("SPIN");
            ComboPattern.Add("UP");
            ComboPattern.Add("DOWN");
            ComboPattern.Add("JUMP");
        }
        public void PrintTheCombo()
        {
            for(int i = 0; i < ComboPattern.Count; i++)
            {
                Console.WriteLine(ComboPattern[i]);
             
              
            }
            
        }
    }
}
