using System;
using System.Text;

namespace DemoStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();
            builder.Append('-', 10)
            .AppendLine()
            .Append("header")
            .AppendLine()
            .Append('-', 10)
            .AppendLine()
            .Replace('-', '+')
            .Remove(0, 10)
            .Insert(0, new String('-', 10));

            Console.WriteLine(builder);
        }
    }
}
