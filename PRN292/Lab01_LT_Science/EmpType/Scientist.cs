using System;

namespace CSharp_4
{
    class Scientist :Manager
    {
        public int PublicNumber{ get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("\t\t\tNumber of public newspaper: ");
            PublicNumber = int.Parse(Console.ReadLine());
        }

        public override void toString()
        {
            base.toString();
            Console.WriteLine($"Number of public newspaper: {PublicNumber}");
        }


    }
}
