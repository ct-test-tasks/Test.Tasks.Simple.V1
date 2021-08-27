using System;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    ///     Что будет выведено на консоль?
    /// </summary>
    internal static class Program
    {
        private static string _result;

        public static void Main(string[] args)
        {
            SyncMethod();
            Console.WriteLine(_result);
        }

        private static async Task<string> SyncMethod()
        {
            await Task.Delay(5);
            _result = "Result 1";
            return "Result 2";
        }
    }
}