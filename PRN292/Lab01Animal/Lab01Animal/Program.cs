using System;

namespace Lab01Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Marutaro", "Shiba Inu");
            Console.WriteLine(dog.information());
            Console.WriteLine("Sound: " + dog.sound());
            Console.WriteLine("");

            Cat cat = new Cat("Shironeko");
            Console.WriteLine(cat.information());
            Console.WriteLine("Sound: " + cat.sound());
            String catState = "Probably a bit sleepy 24/7";
            Console.WriteLine("Status: " + cat.climb(catState));
            Console.WriteLine("");

            Duck duck = new Duck("Vit");
            Console.WriteLine(duck.information());
            Console.WriteLine("Sound: " + duck.sound());
            String duckState = "Vit is swimming in a lake";
            Console.WriteLine("Status: " + duck.swim(duckState));
            Console.WriteLine("");
        }
    }
}
