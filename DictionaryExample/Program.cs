using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> araba = new MyDictionary<string, string>();
            araba.Add("Clio","Renault");
            araba.Add("Astra", "Opel");
            araba.Add("Focus", "Ford");
        }
    }
}
