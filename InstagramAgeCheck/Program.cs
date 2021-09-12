using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //programm kontrollib, kas kasutaja on vanem kui 13 või 13
            //kui kasutaja on 13 aastat vana või vanem, siis ta vüib instgrammi kasutada
            //kui kasutaja on noorem kui 13, siis ta on liiga noor

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor.");
            }
            else
            {
                Console.WriteLine("Oled piisavalt vana.");
            }

            Console.WriteLine("Head päeva!");

        }
    }
}
