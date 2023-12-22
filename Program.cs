class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Khai bao phan tu cua mang");
        Console.WriteLine("Nhap so hang cua hang");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap so cot cua hang");
        int column = int.Parse(Console.ReadLine());
        int[,] array = new int[row, column];
        Console.WriteLine("Nhap thanh phan cua mang");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Mang la: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
        // tinh tong duong cheo chinh cua ma tran
        int sum = 0;
        for (int i = 0;i < row; i++)
        {
            for(int j = 0;j < column; j++)
            {
                if (i==j)
                {
                    sum += array[i, j];
                }
            }
        }
        Console.WriteLine("Tong duong cheo chinh la: " + sum);
    }
}