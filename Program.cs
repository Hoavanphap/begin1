using System;

namespace BaiTap2_3
{
    class baitapvenha
    {
        static void Main(string[] args)
        {
            int tong = 0;
            int tram = 0;
            int donvi = 0;
            int chuc = 0;
            int a = 100;
            for (int i = 100; i <= 999; i++)
            {
                a++;
                tram = a / 100;
                donvi = a % 10;
                chuc = a / 10 % 10;
                tong = tram + chuc + donvi;
                //Console.WriteLine("so thu  : {0}", a);
                //Console.WriteLine("So hang tram : {0}", tram);
                //Console.WriteLine("So hang tram : {0}", tram);
                //Console.WriteLine("So hang chuc : {0}", chuc);
                //Console.WriteLine("So hang donvi : {0}", donvi);
                if (tong % 2 == 0)
                {
                    Console.WriteLine("Tong 3 so la so chan : {0}", tong);
                    Console.WriteLine("So thoa man dieu kien la : {0}", a);
                }
                //else
                //    Console.WriteLine("Tong 3 so la so le ");

            }
        }
    }
}
