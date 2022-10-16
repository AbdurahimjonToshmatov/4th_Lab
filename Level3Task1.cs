using System.Collections.Generic;
using System.Windows.Markup;

class HelloWorld
{
    static int Main()
    {
        Console.WriteLine("Enter the first matrix size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second matrix size: ");
        int m = Convert.ToInt32(Console.ReadLine());
        List<List<int>> matrix = new List<List<int>>();
        List<List<int>> buffer = new List<List<int>>();
        var A = new List<int>();
        var B = new List<int>();
        var C = new List<int>();
        var mas = new List<int>();
        int[] str = new int[n];
        Console.WriteLine("Enter the matrix: ");
        for (int i = 0; i < n; i++)
        {
            matrix.Add(new List<int>());
            string[] line = Console.ReadLine().Split(" ");
            for (int j = 0; j < m; j++)
            {
                matrix[i].Add(Convert.ToInt32(line[j]));
            }
        }
        for (int i = 0; i < n; i++)
        {
            A.Add(matrix[i].Min());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < A.Count(); j++)
            {
                if (A[j] == A.Max()) { B.Add(j); A[j] = A.Min() - 1; break; }
            }
        }
        for (int i=0; i<n; i++)
        {
            buffer.Add(new List<int>());
            for (int j=0; j < matrix[0].Count(); j++)
            {
                buffer[i].Add(matrix[i][j]);
            }
        }
        for (int i=0; i<n; i++)
        {
            matrix[i] = buffer[B[i]];
        }
        Console.WriteLine("New matrix: ");
        for (int i = 0; i < matrix.Count(); i++)
        {
            for (int j = 0; j < matrix[0].Count(); j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
        return 0;
    }
}
