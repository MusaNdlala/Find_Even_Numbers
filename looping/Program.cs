using System;

namespace looping
{
    class Program
    {
        static void Main(string[] args)
        {
            //int j = 1 % 1;
            //Console.WriteLine(j);
            evenNum(1,50);
            Console.ReadLine();
        }
        static void evenNum(Int16 intStartNum, Int16 intEndNum){
            while (intStartNum <= intEndNum)
            {
                if ((intStartNum % 2) == 0)
                {
                    Console.WriteLine(intStartNum);
                }
                intStartNum++;
            }
        }
    }
}
