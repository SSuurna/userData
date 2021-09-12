using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm arvutab kasutaja vanust
            //kui kasutaja on noorem kui 18, siis kuvab konsoolis
            //"oled liiga noor"
            //kui kasutaja on vanem kui 18, siis kuvab konsoolis
            //"oled piisavalt vana"
            //kui kasutaja on 18, siis kuvab konsoolis
            //"Palju õnne!"

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - YearOfBirth;

            if(userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana!");
            }
            else if(userAge < 18)
            {
                Console.WriteLine("Oled veel liiga noor!");
            }
            else
            {
                Console.WriteLine("Palju õnne! Oled 18!");
            }
        }
    }
}
