using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {








            string TaskA = await  GetDataAAsync();
            string TaskB = await GetDataBAsync();
           
            Console.WriteLine(TaskA);
            Console.WriteLine(TaskB);
            Console.ReadLine(); 


        }
        private static async Task GetDataAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("Recieved Data");
            Console.ReadLine();
        }
        public static async Task<string> GetFileAsync(string filepath)
        {
            string result = await Task.Run(() => File.ReadAllText(filepath));
            await Task.Delay(5000);
            return result;    
        }
        public static async Task<string> GetDataAAsync()
        {
            await Task.Delay(1000);
            return "Data from service A";
        }
        public static async Task<string> GetDataBAsync()
        {
            await Task.Delay(5000);
            return "Data from service B";
        }
    }
   
}
