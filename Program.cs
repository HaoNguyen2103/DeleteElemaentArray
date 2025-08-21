using System;

class Program
{
    static void Main()
    {

        Console.Write("Nhập số lượng phần tử N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[N];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"array[{i}] = ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Nhập phần tử cần xóa X: ");
        int X = Convert.ToInt32(Console.ReadLine());

        int index_del = -1;
        for (int i = 0; i < N; i++)
        {
            if (array[i] == X)
            {
                index_del = i;
                break;
            }
        }

        if (index_del != -1)
        {
            for (int i = index_del; i < N - 1; i++)
            {
                array[i] = array[i + 1]; 
            }
            N--;

            
            Console.WriteLine($"Mảng sau khi xóa phần tử {X}:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        else
        {
            Console.WriteLine($"Phần tử {X} không tồn tại trong mảng.");
        }
    }
}
