using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_upcasting_and_downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text(); // downcasting
            Text text = (Text) shape;

            //shape.Width;
            //text.FontName;
        }

        public void Upcasting()
        {
            Text text = new Text();
            Shape shape = text; // upcasting, implicit convertion

            //text.FontName;
            //shape.Width;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            //StreamReader reader = new StreamReader(new FileStream());
            //StreamReader reader = new StreamReader(new MemoryStream());

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Mosh");
            list.Add(new Text());

            var another_list = new List<Shape>();
        }
    }
}
