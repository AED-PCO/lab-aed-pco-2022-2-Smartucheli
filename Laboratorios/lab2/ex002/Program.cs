using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sm(3, 3));
        }

        static int Sm(int val, int x){
            if(x == 0){
                return 0;
            } else if(x > 0){
                return Sm(val, x-1) + val;
            } else {
                return Sm(val, x+1) + val;
            }
            
        }
    }
}
