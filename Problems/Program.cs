using System;
using System.Diagnostics;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press 1 for Swapping the Nibbles\n Press 2 for Customize Message through Regex" +
                    "\n Press 3 for Bubble sort using generics \n Press 4 for Balanced Parenthesis \n Press 5 for Banking Counter" +
                    "\n Press 6 for unordered List \n Press 8 for Stock Portfolio Problem \n Press 9 for Exit");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        SwapNibbles swapNibbles = new SwapNibbles();
                        break;
                    case 2:
                        CustomizeMessage message = new CustomizeMessage();
                        break;
                    case 3:
                        Console.WriteLine("Enter the number of elements you want in array");
                        int n=Convert.ToInt32(Console.ReadLine());
                        int[] arr = new int[n];
                        for(int i=0; i<n; i++)
                        {
                            arr[i]=Convert.ToInt32(Console.ReadLine());
                        }
                        BubbleGenerics bubbleGenerics= new BubbleGenerics();

                        bubbleGenerics.sort(arr);
                        break;
                    case 4:

                        BalancedParenthesis<char> balancedParenthesis= new BalancedParenthesis<char>();
                        string exp=Console.ReadLine();
                        bool res=balancedParenthesis.IsBalanced(exp);
                        if (res == true)
                        {
                            Console.WriteLine("The Parenthesis are balanced");
                        }
                        else { Console.WriteLine("Parenthesis are not balanced"); }
                        break;
                    case 5:
                        Console.WriteLine("Enter the max people in one row");
                        int n2= Convert.ToInt32(Console.ReadLine());
                        BankingCounter<int> ban=new BankingCounter<int>(n2);
                        bool b1 = true;
                        while (b1)
                        {
                            Console.WriteLine("Enter the choice you want to perform");
                            Console.WriteLine("Press 1 for Enqueue");
                            Console.WriteLine("Press 2 for Dequeue\n Press 3 for Exit");
                            int choice=Convert.ToInt32(Console.ReadLine());

                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("Enter the Amount you want to Deposit/Withdraw");
                                    int amount=Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Deposit for deposting money and Withdraw for withdrawing money");
                                    string message1 = Console.ReadLine();
                                    ban.Enqueue(amount, message1);
                                    break;
                                case 2:
                                    ban.Dequeue();
                                    break;
                                case 3:
                                    b1 = false;
                                    break;

                            }
                        }
                        
                        
                        break;
                    case 6:
                        UnorderedList<string> list=new UnorderedList<string>();
                        string path = @"D:\readtxt.txt";
                        string data="";
                        if (File.Exists(path))
                        {
                            data = File.ReadAllText(path);
                            

                        }
                        string[] arr1 = data.Split(' ');
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            Node<string> a2=new Node<string>(arr1[i]);
                            list.AddLast(a2);

                        }
                        list.Traverse();
                        Console.WriteLine("Enter element that you want to search");
                        string search=Console.ReadLine();
                        list.search(search);

                        break;
                    case 7:
                        JsonInventory json = new JsonInventory();
                        json.WriteJson("D:\\BridgeLabz_Problems\\Problems\\ReadJson.json");
                        json.ReadJson("D:\\BridgeLabz_Problems\\Problems\\ReadJson.json");
                        break;
                    case 8:
                        
                        StockAccount stock=new StockAccount();
                        stock.stock(3);
                        break;

                    case 9:
                        b = false;
                        break;
                }
            }
        }
    }
}
