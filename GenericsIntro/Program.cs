using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<string> isimler = new MyList<string>();
            //isimler.Add("Soner");
            //Console.WriteLine(isimler.Length);
            //isimler.Add("Engin");
            //Console.WriteLine(isimler.Length);

            //foreach (var isim in isimler.Items)
            //{
            //    Console.WriteLine(isim);
            //}


            //Dictionary

            MyDictionary<int, string> myDictionary1 = new MyDictionary<int, string>();
            myDictionary1.Add(0, "Engin");
            myDictionary1.Add(1, "Soner");
            myDictionary1.Add(2, "Deniz");
            myDictionary1.Add(3, "Ahmet");
            myDictionary1.Add(4, "Cengiz");
            Console.WriteLine("Entered Value: " + myDictionary1.Count);
            myDictionary1.Show();



        }
    }
}
