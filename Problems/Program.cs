using System;
namespace Problems
{
    public class Program
    {
        string Prefix(string input){
            if(input == null){
                return "0,0:";
            }
            else
            {
            int len = input.Length;
            string[] myWords = input.Split(' ');
            int wlen = myWords.Length;
            string result = $"{len},{wlen}:{input}";
            return result;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
