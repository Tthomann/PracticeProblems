using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Problem5
    {
        string person;
        
        public Problem5()
        {

        }
        public string ArmUp()
        {
            person = @"            
                     *  *
                   *      *
                     *  *        *
                       *      *
                   *  *  *
                 *    *    
               *      *      
                       *
                   *      *
                 *          *
               *              *
             *                  *
           *                      * ";
            return person;
        }
        public string ArmDown()
        {
            person = @"             
                     *  *
                   *      *
                     *  *        
                       *      
                   *  *  *
                 *    *    *
               *      *      *
                       *
                   *      *
                 *          *
               *              *
             *                  *
           *                      * ";
            return person;
        }
        public void Repeat()
        {
            for (int number = 0; number < 5; number++) {
                if (number % 2 == 0)
                {

                    Console.WriteLine(ArmUp());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(ArmDown());
                    Console.ReadLine();
                }
            }
        }
       
    }
}
