using System;
using Home_Work_18_11_2023;

namespace Tumakov
{
    class Program
    {
        /*Тумаков 10.1 создать интерфейс и классы с его реализацией.*/
        static void Main()
        {
            
            Console.WriteLine("Тумаков 10.1 - Создать интерфейс ICipher и классы ACipher и BCipher, которые шифруют и дешифруют код по своему.");
            Console.WriteLine("Дана начальная строка: Hello Вован 122\n\nРабота класса ACipher:");

            string Adecode = "Ifmmp Гпгбо 122";
            string Bdecode = "Svool Эрэяс 122";
            string encode = "Hello Вован 122";

            ACipher acipher = new ACipher();          
            Console.Write("Итог шифрования - ");
            acipher.Encode(encode);
            Console.Write("Итог дешифрования - ");
            acipher.Decode(Adecode);

            BCipher bcipher = new BCipher();
            Console.WriteLine("\nРабота класса BCipher:");
            Console.Write("Итог шифрования - ");
            bcipher.Encode(encode);
            Console.Write("Итог дешифрования - ");
            bcipher.Decode(Bdecode);
        }        
    }
}
