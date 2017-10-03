using System;

namespace Lab05
{
    class Dog
    {
        static void bark()
        {
            string name = "Fido";
            Console.WriteLine("{0} is Barking...", name);
        }

        static void doTrick()
        {
            string trickName = "rollover trick";
            string name = "Fido";
            Console.WriteLine("{0} is so smart! {0} is doing a {1}", name, trickName);
        }
    }
}
