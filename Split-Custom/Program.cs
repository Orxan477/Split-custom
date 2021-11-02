using System;
using System.Text;
namespace Split_Custom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter :");           
            string str = Console.ReadLine();
            Console.WriteLine("--------------");
            Console.Write("Seperator:");
            char seperator = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("--------------");
            Console.WriteLine(Split(str,seperator));
        }

        static string[] Split(string str, char seperator)
        {
            int m = 0;
            
            StringBuilder result = new StringBuilder();

            string[] arr = new string[str.Length];
            int k = 0,
                l = 0;
            for (int i = k; i < str.Length; i++)
            {
                if (str[i]==seperator||i==str.Length-1)
                {
                    l = i;
                    if (i==str.Length-1)
                    {
                        l = i + i;
                    }
                    for (int j = k;  j < l;  j++)
                    {
                        result.Append(str[j]);
                    }
                    
                }
            }
            
        }
    }
}
