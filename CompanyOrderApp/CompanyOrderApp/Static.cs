using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyOrderApp
{
    static class Static
    {
        public static void Display() {
            Console.WriteLine("Display class of static class");
        }
    }
    sealed class ClassDemo : StaticDemo { 
        // SEALED CLASS CANNOT BE FURTHER INHERITED
    }
    class StaticDemo {
        static void Main() {
            Static.Display();
        }
    }
}
