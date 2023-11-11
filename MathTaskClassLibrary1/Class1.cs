using System.Collections.Generic;
using System.Linq;

namespace MathTaskClassLibrary1
{
    public class Class1
    {
        public int CoutElement(List<double> collection) 
        { 
            int k = 0;
            
            for (int i = 0; i < collection.Count(); i++)
            {
                if (collection[i] == 0)
                    break;
                else if (collection[i + 1] == 0)
                    continue;
                else if (collection[i] < collection[i + 1])
                    k++;
            }

            return k; 
        }
    }
}