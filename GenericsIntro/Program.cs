using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isim = new MyList<string>();
            isim.Add("Tankut");
            isim.Add("Kibar");
            isim.Add("Kemal");
            isim.Add("Gülsün");

            foreach (var item in isim.Items)
            {
                Console.WriteLine(item);
            }


        }
    }
}
