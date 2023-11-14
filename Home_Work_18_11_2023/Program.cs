using System;
using System.Collections.Generic;
using System.Linq;

namespace Tumakov
{
    class Program
    {
        interface ICipher
        {
            void Decode(string str);
            void Encode(string str);           
        }
        class ACipher : ICipher
        {
            string alpha_rus = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string alpha_eang = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            public void Encode(string input_str)
            {
                string output_str = "";
                for (int i = 0; i < input_str.Length ; i++)
                {
                    if (input_str[i] == 'z')
                    {
                        output_str += 'a';
                    }
                    else if (input_str[i] == 'я')
                    {
                        output_str += 'а';
                    }
                    else if (input_str[i] == 'Z')
                    {
                        output_str += 'A';
                    }
                    else if (input_str[i] == 'Я')
                    {
                        output_str += 'А';
                    }
                    else if (alpha_eang.Contains(input_str[i]))
                    {
                        int index = alpha_eang.IndexOf(input_str[i]) + 1;
                        output_str += alpha_eang[index];
                    }
                    else if (alpha_rus.Contains(input_str[i]))
                    {
                        int index = alpha_rus.IndexOf(input_str[i]) + 1;
                        output_str += alpha_rus[index];
                    }
                    else if (input_str[i] == ' ')
                    {
                        output_str += ' ';
                    }
                    else
                    {
                        output_str += input_str[i];
                    }
                }
                Console.WriteLine(output_str);
                
            }
            public void Decode(string input_str)
            {
                string output_str = "";
                for (int i = 0; i < input_str.Length; i++)
                {
                    if (input_str[i] == 'a')
                    {
                        output_str += 'z';
                    }
                    else if (input_str[i] == 'а')
                    {
                        output_str += 'я';
                    }
                    else if (input_str[i] == 'А')
                    {
                        output_str += 'Я';
                    }
                    else if (input_str[i] == 'A')
                    {
                        output_str += 'Z';
                    }
                    else if (alpha_eang.Contains(input_str[i]))
                    {
                        int index = alpha_eang.IndexOf(input_str[i]) - 1;
                        output_str += alpha_eang[index];
                    }
                    else if (alpha_rus.Contains(input_str[i]))
                    {
                        int index = alpha_rus.IndexOf(input_str[i]) - 1;
                        output_str += alpha_rus[index];
                    }
                    else if (input_str[i] == ' ')
                    {
                        output_str += ' ';
                    }
                    else
                    {
                        output_str += input_str[i];
                    }
                }
                Console.WriteLine(output_str);
            }
        }
        static void Main()
        {
            ACipher s = new ACipher();
            string encode_str = "Hello Даня";
            string decode_str = "Ifmmp Ебоа";
            s.Encode(encode_str);
            s.Decode(decode_str);
            Console.ReadKey();
        }
    }
}
