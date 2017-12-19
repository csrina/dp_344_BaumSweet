using System;
using System.Collections.Generic;

namespace dp_344_Baum_Sweet
{
    class Baum_Sweet
    {
        private static  int BaumCalc (int num)
        {
            string binStr = Convert.ToString(num, 2);
            string[] splitUp;
            splitUp = binStr.Split("1", StringSplitOptions.None);
            for (int i = 0; i <splitUp.Length; i++)
                if(!String.IsNullOrEmpty(splitUp[i]) && splitUp[i].Length%2 == 1) {
                        return 0;
                }
            return 1;
        }
        private static int[] BaumPre(int num)
        {

            int[] res = new int[num+1];
            for (int i = 0; i <= num; i++) {
                res[i] = (i == 0) ? 1 :  BaumCalc(i);
            }
            return res;
        }
        public static void Main(string[] args)
        {
            int[] test = new int [] {-1, 0, 1, 4, 5, 20};
            string res;
            foreach (int i in test) {
                res = i >=0? string.Join(",", BaumPre(i)) : "Invaild number";
                Console.WriteLine(res);
            }
        }
    }
}