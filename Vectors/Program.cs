using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vector> vectors = new List<Vector>();
            while (Console.ReadLine() !="stop")
            {
                Vector vector;
                if (InputVectorDialog(out vector))
                {
                    vectors.Add(vector);
                }
                ShowResult(vectors);
            }
            vectors.Sort();
            ShowResult(vectors);
            Console.ReadKey();
        }

        private static bool InputVectorDialog(out Vector vector)
        {
            vector = null;
            char first;
            char second;
            int x1;
            int y1;
            int x2;
            int y2;
            Console.Write("First point char:");
            first = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("First point char x:");
            if (!int.TryParse(Console.ReadLine(), out x1)) return false;
            Console.WriteLine();
            Console.Write("First point char y:");
            if (!int.TryParse(Console.ReadLine(), out y1)) return false;
            Console.WriteLine();
            Console.Write("Second point char:");
            second = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Second point char x:");
            if (!int.TryParse(Console.ReadLine(), out x2)) return false;
            Console.WriteLine();
            Console.Write("Second point char y:");
            if (!int.TryParse(Console.ReadLine(), out y2)) return false;
            Console.WriteLine();
            vector = new Vector(first, second, x1, y1, x2, y2);
            return true;

        }

        private static void ShowResult(IEnumerable<Vector> vectors )
        {
            Console.Clear();
            Console.WriteLine(new string('=',15));
            foreach (Vector vec in vectors)
            {
                Console.WriteLine(vec);
            }
            Console.WriteLine(new string('=', 15));
        }
    }
}
