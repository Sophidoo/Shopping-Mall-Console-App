using System.Runtime.InteropServices;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string[] names = { "Adebayo", "Mike", "Sophia", "David", "Faithful", "Obinna" };

            Array.Sort(names);

                for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("Enter your age:");
            int[] age = new int[5];
            age[0] = Convert.ToInt32(Console.ReadLine());
            age[1] = Convert.ToInt32(Console.ReadLine());
            age[2] = Convert.ToInt32(Console.ReadLine());
            age[3] = Convert.ToInt32(Console.ReadLine());
            age[4] = Convert.ToInt32(Console.ReadLine());

            

            for( int i = 0; i < age.Length; i++)
            {

                Console.WriteLine(age[i]);
            }*/

            /*Create an array that will store the score of student in the class*/

            /*Console.WriteLine("Enter the number of grades for the student");
            int studentNumber = Convert.ToInt32(Console.ReadLine());

            int[] students = new int[studentNumber];
            int number = 0;

            for(int i = 0; i < students.Length; i++)
            {
                students[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your Student grades Are");
            for(int i = 0; i < students.Length; i++)
            {
                number++;
                
               
                Console.WriteLine(number + ": " + students[i]);
            }*/



            string[,] cars =
            {
                { "Corolla", "Camry", "Venza" },
                { "Civic", "Pilot", "Accord" },
                { "Mayberk", "G-wagon", "GLK" }
            };


            /*foreach (string cr in cars)
            {
                Console.WriteLine(cr);
            }*/


            for (int i = 0; i < cars.GetLength(0); i++)
            {
                for (int j = 0; j < cars.GetLength(1); j++)
                {
                    Console.Write(cars[i, j]+" ");
                }
                Console.WriteLine();
            }





            Console.ReadKey();
        }
    }
}