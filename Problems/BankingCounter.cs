using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    internal class BankingCounter<T>
    {
       
            public T[] ele;
            public int front;
            public int rear;
            public int max;
        public dynamic sum=0;
            public BankingCounter(int size) {
                ele= new T[size];
                front= 0;
                rear= -1;
                max= size;
            
        }
             
            public void Enqueue(T item,string message)
        {
                if (rear == max - 1)
                {
                    Console.WriteLine("Maximum people reached");
                    return;

                }
                else
                {
                if (message.Equals("Withdraw"))
                {
                    sum -= item;
                    Console.WriteLine($"Amount {message}");
                    
                }
                else
                {
                    sum += item;
                    Console.WriteLine($"Amount {message}");
                    //Console.WriteLine($"The Cash Balance in Counter is {sum}");
                }
                
                ele[++rear]=item;
                


            }

            }
            public void Dequeue()
            {
            T   item= ele[front];
                if (front == rear + 1)
                {
                    Console.WriteLine("No People is there. Queue is empty");
                    return;
                }
                else
                {
                Console.WriteLine($"The Cash Balance in Counter is {sum}");
                front++;
                
                
                
                    
                
                }
            }


        
    }
    }

