using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class ForLoop
    {
        public ForLoop()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public void WhileLoop()
        {
            int num = 10;
            int counter = 0;
            while (counter != num)
            {
                Console.WriteLine(counter);
                counter++;
            }
        }

        public void ForEachLoop()
        {
            int[] varArray = new int[] { 1, 2, 3, 4, 5 };

            foreach(int item in varArray)
            {
                Console.WriteLine(item);
            }
        }

        public void ForEachLoopString()
        {
            String[] strArray = new String[] { "vai", "bh", "av" };
            foreach(String item in strArray)
            {
                Console.WriteLine(item);
            }
        }

        public void ForEachLoopChar()
        {
            Char[] charArray = new Char[] { 'v', 'a', 'i' };
            foreach(Char item in charArray)
            {
            Console.WriteLine(item);
            }
        }
    }


