using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;

            Console.WriteLine("Palun, sisesta oma vanus:");
            int ageOfBirth = Convert.ToInt32(Console.ReadLine());

            int yearOfBirth = 2021 - ageOfBirth;
            Console.WriteLine($"Oled sündinud aastal {yearOfBirth}.");


        }
    }
}
