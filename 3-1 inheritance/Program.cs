﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
