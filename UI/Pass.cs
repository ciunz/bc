using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI
{
    public class Pass
    {
        public string AddZero(string id)
        {
            int qty = 10 - id.Length;
            string zero = "";
            for (int i = 1; i <= qty; i++)
            {
                zero += "0";
            }
            return zero;
        }
    }
}