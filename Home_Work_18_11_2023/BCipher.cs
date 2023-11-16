using System;
using System.Linq;

namespace Home_Work_18_11_2023
{
    class BCipher : ICipher
    {
        string eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        string eng_rev = "ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcba";
        string rus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string ru_rev = "ЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБАяюэьыъщшчцхфутсрпонмлкйизжёедгвба";
        public void Encode(string str)
        {
            string output_string = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (eng.Contains(str[i]))
                {
                    int index = eng.IndexOf(str[i]);
                    output_string += eng_rev[index];
                }
                else if (rus.Contains(str[i]))
                {
                    int index = rus.IndexOf(str[i]);
                    output_string += ru_rev[index];
                }
                else
                {
                    output_string += str[i];
                }
            }
            Console.WriteLine(output_string);
        }
        public void Decode(string str)
        {
            string output_string = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (eng_rev.Contains(str[i]))
                {
                    int index = eng_rev.IndexOf(str[i]);
                    output_string += eng[index];
                }
                else if (ru_rev.Contains(str[i]))
                {
                    int index = ru_rev.IndexOf(str[i]);
                    output_string += rus[index];
                }
                else
                {
                    output_string += str[i];
                }
            }
            Console.WriteLine(output_string);
        }
    }
}
