using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkLesson9_3
{
    class MyClass
    {
        [Obsolete("Данный метод является устаревшим!. Используйте MessageNew().")]
        public void MessageOld()
        {
            Console.WriteLine("Message Old");
        }

        public void MessageNew()
        {
            Console.WriteLine("Message New");
        }

        [Obsolete("Данный метод является устаревшим и его нельзя использовать!", true)]
        public void Method()
        {
            Console.WriteLine("Method");
        }
    }
}
