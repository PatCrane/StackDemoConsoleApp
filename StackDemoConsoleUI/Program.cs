using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StackDemoConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack showsToWatch = new Stack(4);

            showsToWatch.Push("Star Trek - The Next Generation");
            showsToWatch.Push("True Blood");
            showsToWatch.Push("Stranger Things");
            showsToWatch.Push("The Office");
            showsToWatch.Push("Game of Thrones");

            Console.WriteLine("<<< Going to peek: >>>");
            Console.WriteLine();

            Console.WriteLine($"{ showsToWatch.Peek() } is at the top of the stack.");


            Console.WriteLine("<<< The Stack Contains >>>");
            Console.WriteLine();

            while (!showsToWatch.IsEmpty())
            {
                string show = showsToWatch.Pop();
                Console.WriteLine(show);
            }


            Console.ReadLine();
        }
    }

    public class Stack
    {
        private int MaxSize { get; set; }
        
        private string[] StackArray;

        private int Top; //Index position of the last item in the stack

        public Stack(int size)
        {
            MaxSize = size;

            StackArray = new string[MaxSize];

            Top = -1;
        }

        public void Push(string s)
        {
            //Check to see if the stack is full
            if (IsFull())
            {
                Console.WriteLine("This stack is full.");
            }
            else
            {
                Top++;

                StackArray[Top] = s;
            }
        }

        private bool IsFull()
        {
            return (MaxSize - 1 == Top);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The stack is empty.");
                return "--";
            }
            else 
            {
                int OldTop = Top;
                Top--;
                return StackArray[OldTop];
            }
        }

        //Lets you see the current item sitting at the top of the stack
        public string Peek()
        {
            string output = StackArray[Top];

            
            
            return output;
        }

        public bool IsEmpty()
        {
            return (Top == -1);
        }
    }
}
