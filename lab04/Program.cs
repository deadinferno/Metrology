using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab04
{
    class Program
    {
        static void Main()
        {
            List<char> dictionary = new List<char>();
            dictionary.AddRange("qwertyuiop[]asdfghjkl;'\\zxcvbnm,./QWERTYUIOP{}ASDFGHJKL:\"|ZXCVBNM<>?1234567890-=!@#$%^&*()_+");
            dictionary.Sort();
        }
    }
}