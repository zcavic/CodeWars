using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace CodeWars.Algorithms
{


    public class Result
    {

        /*
         * Complete the 'foo' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING_ARRAY codeList
         *  2. STRING_ARRAY shoppingCart
         */

        public static int foo(List<string> codeList, List<string> shoppingCart)
        {
            int k = 0;
            //for (int i = 0; i < codeList.Count; i++)
            foreach(string codeInList in codeList)
            {
                string[] codes = codeInList.Split(' ');
                foreach (string code in codes)
                {
                    bool isFirst = true;
                    if (shoppingCart.Count == 0)
                        return -1;
                    while (shoppingCart.Count > 0)
                    {
                        if (shoppingCart[0] == code ||
                            code == "anything" && shoppingCart[0].Length > 0)
                        {
                            shoppingCart.RemoveAt(0);
                            isFirst = false;
                            break;
                        }
                        else if (isFirst)
                        {
                            shoppingCart.RemoveAt(0);
                            isFirst = false;
                            continue;
                        }
                        return -1;
                    }
                }
            }
            return 1;
        }
    }
}