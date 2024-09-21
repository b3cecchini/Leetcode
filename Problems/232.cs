using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Problems
{
    public class _232
    {
        Stack<int> main;
        Stack<int> temp;
        public _232()
        {
            main = new Stack<int>();
            temp = new Stack<int>();
        }

        public void Push(int x)
        {
            main.Push(x);
        }

        public int Pop()
        {
            int retval;
            while(main.Count > 0)
            {
                temp.Push(main.Pop());
            }
            retval = temp.Pop();
            while(temp.Count > 0)
            {
                main.Push(temp.Pop());
            }
            return retval;
        }

        public int Peek()
        {
            int retval;
            while (main.Count > 0)
            {
                temp.Push(main.Pop());
            }
            retval = temp.Peek();
            while (temp.Count > 0)
            {
                main.Push(temp.Pop());
            }
            return retval;

        }

        public bool Empty()
        {
            return main.Count == 0;
        }

        public void PrintMain()
        {
            Console.WriteLine("Main contents: ");
            foreach(int x in main)
            {
                Console.WriteLine(x);
            }
        }
    }
    /**
     * Your MyQueue object will be instantiated and called as such:
     * MyQueue obj = new MyQueue();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Peek();
     * bool param_4 = obj.Empty();
     */
}
