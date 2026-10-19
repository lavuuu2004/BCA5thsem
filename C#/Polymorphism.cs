using System;
class  Animal
{
    public virtual void speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main()
        {
            Animal a1 = new Animal();
            Animal a2 = new Dog();
            a1.Speak();
            a2.Speak();
        }
    }
}