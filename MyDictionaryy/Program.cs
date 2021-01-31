using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDict<int, string> malzemeler = new MyDict<int, string>();

            malzemeler.Add(1, "Kalem");
            malzemeler.Add(2, "Kitap");
            malzemeler.Add(2, " Suluk");
            malzemeler.Add(3, "Çanta");

            
        }
    }
}
