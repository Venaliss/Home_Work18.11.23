using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_18_11_2023
{
    interface ICipher
    {
        void Decode(string str);
        void Encode(string str);   
    }
}
