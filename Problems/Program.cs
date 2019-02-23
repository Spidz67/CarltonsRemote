using System;

namespace Problems
{
    public class Program
    {
        public string Prefix(string input){
            if (input == null){return null;}

            if(input == ""){
                return "0,0:";
            }
 
            int len = input.Length;
            string[] myWords = input.Split(' ');
            int wlen = 0;
            foreach (string item in myWords)
            {
                if(item != ""){
                    wlen++;
                }
            }
            string result = $"{len},{wlen}:{input}";
            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
