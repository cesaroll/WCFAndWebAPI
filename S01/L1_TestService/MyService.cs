using System;
using System.Collections.Generic;
using System.Linq;

namespace L1_TestService
{
    public class MyService: IMyService
    {
        public string GetData()
        {
            return "www.youtube.com";
        }

        public string GetMessage(string Name)
        {
            return "Hello Mr./Ms " + Name;
        }

        public string GetResult(int Sid, string SName, int M1, int M2, int M3)
        {
            double avg = (M1 + M2 + M3)/3.0;

            if (avg < 35)
                return "Fail";
            else
                return "Pass";

        }

        public int GetMax(int[] ar)
        {
            return ar.Max();
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);

            return ar;

        }
    }
}