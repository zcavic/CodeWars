using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Algorithms
{
    class States
    {
        //METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
        public static int[] cellCompete(int[] states, int days)
        {
            int[] newStates = new int[states.Length];
            for (int i = 0; i < days; i++)
            {
                newStates[0] = 0;
                newStates[states.Length - 1] = 0;
                for (int j = 1; j < states.Length - 1; j++)
                {
                    if ((states[j - 1] == 1 && states[j + 1] == 1) ||
                    (states[j - 1] == 0 && states[j + 1] == 0))
                    {
                        newStates[j] = 0;
                    }
                    else
                    {
                        newStates[j] = 1; 
                    }
                }
                states = Copy(newStates);
            }
            return states;
            // INSERT YOUR CODE HERE
        }

        private static int[] Copy(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
        // METHOD SIGNATURE ENDS
    }

}
