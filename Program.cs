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



            /*string[,] cars =
            {
                { "Corolla", "Camry", "Venza" },
                { "Civic", "Pilot", "Accord" },
                { "Mayberk", "G-wagon", "GLK" }
            };


            foreach (string cr in cars)
            {
                Console.WriteLine(cr);
            }


            for (int i = 0; i < cars.GetLength(0); i++)
            {
                for (int j = 0; j < cars.GetLength(1); j++)
                {
                    Console.Write(cars[i, j]+" ");
                }
                Console.WriteLine();
            }*/


            Console.WriteLine("------------------------------");
            Console.WriteLine("\tSHOPPING MALL ");
            Console.WriteLine("------------------------------");

            
            Console.WriteLine("\n \n>>> Our Shopping Mall Items\n");
            string[,] items = {
                {"---------", "---------------", "----------------" },
                {"   Id.   ", "|     Item     ", "|   Price($)   |" },
                {"---------", "---------------", "----------------" },
                {"1        ", "|Laptop        ", "|200.00        |" },
                {"2        ", "|Toothbrush    ", "|50.00         |" },
                {"3        ", "|T-shirt       ", "|600.00        |" }
            };

            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    Console.Write(items[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n \nHow many items do you want to buy?");
            int itemsNumber = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n \n>>> Please Input the id of the item you want to buy and press enter.");
            int id = Convert.ToInt32(Console.ReadLine());

            id = validId(id);


            Console.Write("\n \n>>> Enter the quantity you want to buy: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            int row = itemsNumber;
            
            int column = 5;

            Console.WriteLine("\n>>> Your Items Bought\n");

            string[,] itemsBought = new string[row, column];

            
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    
                    switch (id)
                    {
                        case 1:
                            itemsBought[i, 0] = "|1        ";
                            itemsBought[i, 1] = "|Laptop        ";
                            itemsBought[i, 2] = "|200.00        ";
                            itemsBought[i, 3] = "|" + Convert.ToString(quantity) + "        ";
                            itemsBought[i, 4] = "|" + Convert.ToString(200 * quantity) + "       ";
                            break;
                        case 2:
                            itemsBought[i, 0] = "|2         ";
                            itemsBought[i, 1] = "|Toothbrush    ";
                            itemsBought[i, 2] = "|50.00         ";
                            itemsBought[i, 3] = "|" + Convert.ToString(quantity) + "        ";
                            itemsBought[i, 4] = "|" + Convert.ToString(50 * quantity) + "        ";
                            break;
                        case 3:
                            itemsBought[i, 0] = "|3          ";
                            itemsBought[i, 1] = "|T-shirt       ";
                            itemsBought[i, 2] = "|600.00        ";
                            itemsBought[i, 3] = "|" +Convert.ToString(quantity) + "         ";
                            itemsBought[i, 4] = "|" +Convert.ToString(600 * quantity) + "         ";
                            break;
                    }
                   /* Console.Write(itemsBought[i, j]);*/
                }
                Console.WriteLine("\n \n \n>>>Do you want to buy another item? If yes write y, if no write n");

                string option = Console.ReadLine();

                if(option.ToLower() == "y")
                {

                    Console.WriteLine("\n \n>>> Our Shopping Mall Items\n");
                    string[,] item = {
                        {"---------", "---------------", "----------------" },
                        {"   Id.   ", "|     Item     ", "|   Price($)   |" },
                        {"---------", "---------------", "----------------" },
                        {"1        ", "|Laptop        ", "|200.00        |" },
                        {"2        ", "|Toothbrush    ", "|50.00         |" },
                        {"3        ", "|T-shirt       ", "|600.00        |" }
                    };

                    for (int x = 0; x < items.GetLength(0); x++)
                    {
                        for (int y = 0; y < items.GetLength(1); y++)
                        {
                            Console.Write(item[x, y]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\n \n>>> Please Input the id of the item you want to buy and press enter.");
                    id = Convert.ToInt32(Console.ReadLine());

                    id = validId(id);

                    Console.Write("\n \n>>> Enter the quantity you want to buy: ");
                    quantity = Convert.ToInt32(Console.ReadLine());

                    continue;

                }
                else
                {
                    break;
                }
            
            }


            Console.WriteLine(">>>>Your Items");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("|   Id    |    Item     |   Price($)   |  Quantity |  SubTotal |");
            Console.WriteLine("----------------------------------------------------------------");
            for (int i = 0; i < itemsBought.GetLength(0); i++)
            {
                for (int j = 0; j < itemsBought.GetLength(1); j++)
                {
                    Console.Write(itemsBought[i, j]);
                }
                Console.WriteLine();
            }










            Console.ReadKey();
        }

        static void getValues(int item_id,int itemno)
        {
            Console.WriteLine("\n \n>>> Our Shopping Mall Items\n");
            string[,] items = {
                {"---------", "---------------", "----------------" },
                {"   Id.   ", "|     Item     ", "|   Price($)   |" },
                {"---------", "---------------", "----------------" },
                {"1        ", "|Laptop        ", "|200.00        |" },
                {"2        ", "|Toothbrush    ", "|50.00         |" },
                {"3        ", "|T-shirt       ", "|600.00        |" }
            };

            for (int i = 0; i < items.GetLength(0); i++)
            {
                for (int j = 0; j < items.GetLength(1); j++)
                {
                    Console.Write(items[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n \nHow many items do you want to buy?");
            itemno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n \n>>> Please Input the id of the item you want to buy and press enter.");
            item_id = Convert.ToInt32(Console.ReadLine());

            item_id = validId(item_id);
        }

        static int validId(int id)
        {

            if (id > 3 || id <= 0)
            {
                Console.WriteLine("Please enter a valid Id");
                id = Convert.ToInt32(Console.ReadLine());
                id = validId(id);

            }
          
            return id;
            
            


        }

    }
}