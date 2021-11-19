//Code by: Chu Quang Thao - 2021
using System;

namespace TongHop_1
{
    class Class1
    {
        //Bài 110: Cần có tổng 200000 đồng từ 3 loại giấy bạc 1000 đồng, 2000 đồng, 5000 đồng. Lập chương trình để tìm ra tất cả các phương án có thể
        public static void ChonTien(int N, int tien1, int tien2, int tien3)
        {
            int dem = 0;
            int kq = 0;
            int m1 = N / tien1;
            int m2 = N / tien2;
            int m3 = N / tien3;
            int Tong = 0;
            for (int i = 0; i <= m3; i++)
            {
                for (int j = 0; j <= m2; j++)
                {
                    for (int k = 0; k <= m1; k++)
                    {
                        dem++;
                        Tong = tien3 * i + tien2 * j + tien1 * k;
                        if (Tong == N)
                        {
                            kq++;
                            Console.WriteLine("{0}-{1}-{2}", i, j, k);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("So ket qua: " + kq);
            Console.WriteLine("So buoc lap: " + dem);
        }

        //Bài 112: Viết chương trình in ra hình chữ nhật có kích thước m x n
        public static void InHCN_Dac(int m, int n)
        {
            for(int i=0; i<m; i++)
            {
                for(int j=0; j<n; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public static void InHCN_Rong(int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || i == m-1)
                        Console.Write('*');
                    else
                    {
                        if(j == 0 || j == n-1)
                            Console.Write('*');
                        else
                            Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }            
        }

        //Bài 111: Viết chương trình in ra tam giác cân có độ cao h
        public static void InTGCan_Dac(int h)
        {
            for(int i = 1; i <= h; i++)
            {
                string space = new String(' ', h - i);
                Console.Write(space);
                string star = new string('*', 2 * i - 1);
                Console.Write(star);
                Console.WriteLine();
            }
        }
        public static void InTGCan_Rong(int h)
        {
            for (int i = 1; i < h; i++)
            {
                for(int j = 1; j <= h - i; j++)
                {
                    Console.Write(' ');
                }
                for (int j = 1; j <= 2*i-1; j++)
                {
                    if(j == 1 || j == 2*i-1)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
            //In canh day
            string star = new string('*', 2 * h - 1);
            Console.WriteLine(star);
        }
        public static void InTGVuongCan_Dac(int h)
        {
            for(int i = 1; i <=h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
        public static void InTGVuongCan_Rong(int h)
        {
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == h) Console.Write("*");
                    else
                    {
                        if (j == 1 || j == i)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
