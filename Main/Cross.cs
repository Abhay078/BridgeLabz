using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class Cross
    {
        static char[] arr = {'0','1','2','3','4','5','6','7','8','9'};
        static int player =1;
        static int choice;
        static int flag = 0;
        public Cross()
        {
            while(flag!=1 && flag !=-1)
            {
                Console.Clear();
                Console.WriteLine("---------------Tic-Tac-Toe Games Starts Here-----------------");
                Console.WriteLine("Player 2 has Cross and person Plays and Player 1 has circle and Computer plays\n\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Your Chance, Please Give position for cell to play");
                    Board();
                    choice = Convert.ToInt32(Console.ReadLine());
                    if (arr[choice] != 'X' && arr[choice] != 'O')
                    {
                        arr[choice] = 'X';
                        player++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry the row is already marked with {arr[choice]}");
                        Console.WriteLine("");
                        Console.WriteLine("Board is Loading again Plz Enter your desired unoccupied cell");
                        Thread.Sleep(2000);
                    }

                }
                else
                {
                    Console.WriteLine("Computer automatically mark the cell");
                    Random random= new Random();
                    Board();
                    choice = random.Next(1,10);
                   
                    if (arr[choice]!='X' && arr[choice] != 'O')
                    {
                        arr[choice] = 'O';
                        player++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry the row is already marked with {arr[choice]}");
                        Console.WriteLine("");
                        Console.WriteLine("Board is Loading again Plz Enter your desired unoccupied cell");
                        Thread.Sleep(2000);
                    }

                }
                flag = Check();
                
                

            }
            Console.Clear();
            Board();
            if (flag == 1)
            {
                if (player == 2)
                {
                    Console.WriteLine("You have won the game");
                }
                else
                {
                    Console.WriteLine("You loss");
                }

            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();


        }
        public static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        public static int Check()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if(arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] !='1' && arr[2] != '2' && arr[3] != '3' && arr[4] !='4' && arr[5]!='5' && arr[6]!= '6' && arr[7]!= '7' && arr[8]!='8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
        
    }
}
