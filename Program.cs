using System;

class Program
{
    static void Main()
    {
        // Bước 1: Khai báo và khởi động mảng số nguyên
        Console.Write("Nhập số lượng phần tử N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[N];
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"array[{i}] = ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Bước 2: Nhập X là phần tử cần xóa
        Console.Write("Nhập phần tử cần xóa X: ");
        int X = Convert.ToInt32(Console.ReadLine());

        // Bước 3: Tìm X trong mảng
        int index_del = -1;
        for (int i = 0; i < N; i++)
        {
            if (array[i] == X)
            {
                index_del = i;
                break;
            }
        }

        // Bước 4: Nếu tìm thấy, thực hiện xóa
        if (index_del != -1)
        {
            for (int i = index_del; i < N - 1; i++)
            {
                array[i] = array[i + 1]; // dịch trái
            }
            N--; // giảm kích thước hợp lệ của mảng

            // Bước 5: In ra mảng sau khi xóa
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
