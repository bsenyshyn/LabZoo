using System;

namespace LabZoo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Zone f1 = new Zone();
            Zone f2 = new Zone();
            AviaryBear ab = new AviaryBear(6);
            AviaryGiraffe ag = new AviaryGiraffe(6);
            AviaryWolf aw = new AviaryWolf(6);

            f1.Add(f2);
            f1.Add(ab);
            f2.Add(ag);
            f2.Add(aw);
            zoo.AddField(f1);         

            zoo.AddAnimal("Snow", 90);
            zoo.AddAnimal("Autumn", 100);
            zoo.AddAnimal("Spring", 144);
            zoo.AddAnimal("Fire", 220);
            zoo.AddAnimal("Wind", 116);
            zoo.AddAnimal("Airflow", 70);
            Console.WriteLine("Overall weight: " + zoo.SumWeight());
            Console.WriteLine("Average weight: " + zoo.AverageWeight());

            Console.WriteLine("\nAnimal voices (day): ");
            zoo.Voice();
            zoo.Night();
            
            Console.WriteLine("\nAnimal voices (night): ");
            zoo.animals[0].Wake();
            zoo.animals[2].Wake();
            zoo.Voice();
            
            Console.WriteLine("\nAnimal voices sleeping (night): ");
            zoo.animals[0].Sleep();
            zoo.animals[2].Sleep();
            zoo.Voice();

            Console.ReadLine();
        }
    }
}