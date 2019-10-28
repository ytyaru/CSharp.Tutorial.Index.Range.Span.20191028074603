using System;
//using System.Collections.Generic;
using System.Linq;

namespace Index_Range_Span.Lesson0
{
    class Main
    {
        private string[] words;
        public Main()
        {
            words = new string[]
            {
                            // index from start    index from end
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0
        }
        public void Run()
        {
            Literal();
            Range0();
            Range1();
            Span0();
            Span1();
        }
        private void Literal()
        {
            Console.WriteLine($"The last word is {words[^1]}");
            Console.WriteLine($"The last word is {words[0..^0]}");
            Console.WriteLine($"The last word is {words[0..words.Length]}");
            Console.WriteLine($"The last word is {words[1..4]}");
            Console.WriteLine($"The last word is {words[^2..^0]}");
            Console.WriteLine($"The last word is {words[..]}");
            Console.WriteLine($"The last word is {words[..4]}");
            Console.WriteLine($"The last word is {words[6..]}");
        }
        private void Range0()
        {
            Range range = 1..4;
            Console.WriteLine($"{words[range]}");
        }
        private void Range1()
        {
            int[] nums = Enumerable.Range(0, 10).ToArray();
            Console.WriteLine($"nums.Length: {nums.Length}");
            Console.WriteLine($"nums: {nums}");
        }
        private void Span0()
        {
            int[] nums = Enumerable.Range(0, 10).ToArray();
            Span<int> span0 = nums[1..4];
//            Console.WriteLine($"{span0}"); // error CS0029: 型 'System.Span<int>' を 'object' に暗黙的に変換できません
            Console.WriteLine($"{span0.Length}");
            Console.WriteLine($"{span0[0]}");
            Console.WriteLine($"{span0[^1]}");
            Console.WriteLine($"{span0.Slice(2).Length}");
        }
        private void Span1()
        {
            int[] nums = Enumerable.Range(0, 10).ToArray();
            Range range = 1..7;
            ReadOnlySpan<int> span0 = nums[range];
            Console.WriteLine($"{span0.Length}");
            Console.WriteLine($"{span0[0]}");
            Console.WriteLine($"{span0[^1]}");
            Console.WriteLine($"{span0.Slice(2).Length}");
        }

    }
}
