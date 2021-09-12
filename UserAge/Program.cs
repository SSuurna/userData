using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanaust
            //programm arvutab kasutaja sünniaastat
            //programm kuvab sünniaastat konsoolis.
            //"oled sündinud aastal {YearOFBirth}"

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            int YearOfBirth = 2021 - userAge;

            Console.WriteLine($"Oled sündinud aastal {YearOfBirth}.");


         
            
        }
    }
}
