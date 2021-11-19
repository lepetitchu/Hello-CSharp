//Code by: Chu Quang Thao - 2021
using System;

namespace TongHop_1
{
    class XL_SoNguyen
    {
        //Bài 1: Tính S(n) = 1 + 2 + 3 + … + n
        public static int TongChuoi_1(int n)
        {
            int kq = 0;
            int i = 1;
            while (i <= n)
            {
                kq += i;
                i++;
            }
            return kq;
        }

        //Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2
        public static int TongChuoi_2(int n)
        {
            int kq = 0;
            int i = 1;
            while (i <= n)
            {
                kq += i * i;
                i++;
            }
            return kq;            
        }

        //Bai 9: Tính T(n) = 1 x 2 x 3…x N (Giai thua)
        public static long GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 2; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }

        // Bài 10: Tính T(x, n) = x^n
        public static double SoMu(double x, int n)
        {
            if (n == 0)
                return 1;
            double kq = 1d;
            for (int i = 1; i <= n; i++)
            {
                kq *= x;
            }
            return kq;
        }

        //Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N
        public static int TongChuoi_11(int n)
        {
            int kq = 0;
            int p = 1;
            int i = 1;
            while (i <= n)
            {
                p *= i;
                kq += p;
                i++;
            }
            return kq;
        }

        //Bài 13: Tính S(n) = x^2 + x^4 + … + x^(2n)    //i=1..n
        public static double TongChuoi_13(double x, int n)
        {
            double p = 1 ,kq = 0;
            int i = 1;
            while (i <= n)
            {
                p *= x * x;
                kq += p;
                i++;
            }
            return kq;
        }

        //Bài 14: Tính S(n) = x + x^3 + x^5 + … + x^(2n + 1)    //i=0..n
        public static double TongChuoi_14(double x, int n)
        {
            double p = x, kq = p;
            int i = 1;
            while (i <= n)
            {
                p *= x * x;
                kq += p;
                i++;
            }
            return kq;
        }

        //Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/n!  //i=1..n
        public static double TongChuoi_17(double x, int n)
        {
            double kq = 0;
            double tuso = 1, mauso = 1;
            int i = 1;
            while (i <= n)
            {
                tuso *= x;
                mauso *= i;
                kq += 1d * tuso / mauso;
                i++;
            }
            return kq;
        }

        //Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!  //i = 0..n
        public static double TongChuoi_18(double x, int n)
        {
            if (n == 0)
                return 1;
            double tuso = 1d, mauso = 1d, kq = 1d;
            for (int i = 1; i <= n; i++)
            {
                tuso *= x * x;
                mauso *= (2 * i - 1) * (2 * i);
                kq += tuso / mauso;
            }
            return kq;
        }

        //Bài 19: Tính S(n) = x + x^3/3! + x^5/5! + … + x^(2n+1)/(2n+1)! -- i = 0..n
        public static double TongChuoi_19(double x, int n)
        {
            if (n == 0)
                return x;
            double tuso = x, mauso = 1d, kq = x;
            for (int i = 1; i <= n; i++)
            {
                tuso *= x*x;
                mauso *= (2 * i) * (2 * i + 1);
                kq += tuso / mauso;
            }
            return kq;
        }

        //Kiem tra SO NGUYEN TO
        public static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        public static bool LaSoNguyenTo_2(long n)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            long i = 5;
            long w = 2;
            while (i * i <= n)
            {
                if (n % i == 0) return false;
                i += w;
                w = 6 - w;
            }
            return true;
        }

        //Kiem tra So Chinh Phuong
        public static bool LaSoChinhPhuong(int N)
        {
            if (N < 1) return false;
            int i = 1;
            while (i * i < N)
            {
                i++;
            }
            if (i * i == N) return true;
            else return false;
        }

        //Bai 20: Liet ke cac Uoc so
        public static void LietKeUocSo(int number)
        {
            Console.WriteLine("Cac uoc so la cua so nguyen: " + number);
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(number);
        }

        //Bai 21: Tính tổng tất cả các “ ước số” của số nguyên dương n
        public static int TongUocSo(int number)
        {
            int kq = 0;
            int i = 1;
            while(i <= number / 2)
            {
                if(number % i == 0)
                    kq += i;
                i++;
            }
            kq += number;
            return kq;
        }

        //Bài 29: Tìm ước số lẻ lớn nhất của số nguyên dương n. Ví dụ n = 100 ước lẻ lớn nhất là 25
        public static int UocSoLeLonNhat(int N)
        {
            int kq = -1;
            int i = 0;
            while (++i <= N / 2)
            {
                if (N % i == 0 && i % 2 != 0)
                {
                    if (i > kq)
                        kq = i;
                }
            }
            return kq;
        }

        //Bai 30: Kiem tra so hoan thien
        public static bool LaSoHoanThien(int N)
        {
            int Sum = 0;
            int i = 0;
            while (++i <= N / 2)
            {
                if (N % i == 0)
                    Sum += i;
            }
            return (Sum == N);
        }

        //Bài 42, Bài 90: Cho n là số nguyên dương. Hãy tìm giá trị nguyên dương k lớn nhất sao cho S(k) < n. Trong đó chuỗi k được định nghĩa như sau: S(k) = 1 + 2 + 3 + … + k
        public static int TimSoKMax(int n)
        {
            if (n == 1)
                return 0;
            int k = 0, S = 0;
            do
            {
                k++;
                S += k;
            }
            while (S < n);
            return k-1;
        }

        //Bài 87: Tìm số nguyên dương k nhỏ nhất sao cho 1 + 2 + … + k > n; ví dụ n=10000
        public static int TimSoKMin(int n)
        {
            if (n == 0)
                return 1;
            int k = 0, S = 0;
            while (S <= n)
            {
                k++;
                S += k;
            }
            return k;
        }

        //Bai 62: Tim Uoc Chung Lon Nhat cua 2 so nguyen
        public static int UCLN(int A, int B)
        {
            //Phuong phap Chia du
            while (A * B != 0)
            {
                if (A > B)
                    A %= B;
                else
                    B %= A;
            }
            return A + B;
        }

        public static int UCLN_Euclid(int A, int B)
        {
            //Phuong phap Euclid
            if (B == 0)
                return A;
            return UCLN_Euclid(B, A % B);
        }

        //Bai 63: Tim Boi Chung Nho Nhat cua 2 so nguyen
        public static int BCNN(int A, int B)
        {
            return (A * B / UCLN(A, B));
        }

        //Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn
        public static double Bai33(int n)
        {
            //if (n <= 0)
            //    return -1;
            //if (n == 1)
            //    return Math.Sqrt(2);
            //return Math.Sqrt(2 + Bai33(n - 1));

            double kq = Math.Sqrt(2);
            for (int i = 2; i <= n; i++)
            {
                kq = Math.Sqrt(2 + kq);
            }
            return kq;
        }

        //Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)...)  có n dấu căn
        public static double Bai34(int n)
        {
            //Recursion 
            //if (n == 1)
            //    return 1;
            //return Math.Sqrt(n + Bai34(n - 1));

            double kq = 1;
            for (int i = 2; i <= n; i++)
            {
                kq = Math.Sqrt(i + kq);
            }
            return kq;
        }

        //Bài 36: Tính S(n) = CanBac2(n! + CanBac2((n-1)! +CanBac2((n – 2)! + … + CanBac2(2!) + CanBac2(1!)))) có n dấu căn
        public static double Bai36(int n)
        {
            int gt = 1;
            double kq = 1.0;
            for (int i = 2; i <= n; i++)
            {
                gt *= i;
                kq = Math.Sqrt(gt + kq);
            }
            return kq;
        }

        //Bài 37: Tính S(n) = CanBacN(N + CanBac(N–1)(N–1 + … + CanBac3(3 + CanBac2(2))) có n – 1 dấu căn
        public static double Bai37(int n)
        {
            if (n <= 1)
                return -1;
            if (n == 2)
                return Math.Sqrt(2);
            return Math.Pow(n + Bai37(n - 1), 1.0 / n);
        }

        //Bài 38: Tính S(n) = CanBac(N+1)(N + CanBacN(N–1 +…+CanBac3(2 + CanBac2(1)))) có n dấu căn
        public static double Bai38(int n)
        {
            if (n <= 0)
                return -1;
            if (n == 1)
                return 1;
            return Math.Pow(n + Bai38(n - 1), 1.0 / (n + 1));
        }

        //Bài 40: Tính S(n) = CanBac2(x^n + CanBac2(x^(n-1) + … + CanBac2(x^2 + CanBac2(x)))) có n dấu căn
        public static double Bai40(double x, int n)
        {
            if (n <= 0)
                return -1;
            double kq = Math.Sqrt(x);
            if (n == 1)
                return kq;
            for (int i = 2; i <= n; i++)
            {
                kq = Math.Sqrt(Math.Pow(x, i) + kq);
            }
            return kq;
        }

        //Bài 41: Tính S(n) = 1 / (1 + 1 / ( 1 + 1 / (…. 1 + 1 / (1 + 1))) có n dấu phân số - Golden Ratio
        public static double Bai41(int n)
        {
            //if (n <= 0)
            //    return -1;
            //if (n == 1)
            //    return 1;
            //return 1.0 / (1.0 + Bai41(n - 1));
            double kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq = 1.0 / (kq + 1);
            }
            return kq;
        }

        public static double GoldenRatio(int n)
        {
            //if (n <= 0)
            //    return -1;
            //if (n == 1)
            //    return 1;
            //return Math.Sqrt(1d + GoldenRatio(n - 1));
            double kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq = Math.Sqrt(kq + 1);
            }
            return kq;
        }

        //Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n
        public static int DemChuSo(int n)
        {
            int dem = 0;
            while (n != 0)
            {
                dem++;
                n /= 10;               
            }
            return dem;
        }

        //Bài 44: Hãy tính tổng các chữ số của số nguyên dương n
        public static int TongChuSo(int n)
        {
            int r, Tong = 0;
            while (n != 0)
            {
                r = n % 10; //Lay so hang don vi
                n /= 10;    //Lay phan con lai
                Tong += r;
            }            
            return Tong;
        }
      
        //Bài 45: Hãy tính tích các chữ số của số nguyên dương n
        public static int TichChuSo(int n)
        {
            int r, Tich = 1;
            while (n != 0)
            {
                r = n % 10; //Lay so hang don vi
                n /= 10;    //Lay phan con lai
                Tich *= r;
            }           
            return Tich;
        }

        //Su dung Recursion
        public static int TongChuSo2(int n)
        {
            if (n / 10 == 0)
                return n;
            return n % 10 + TongChuSo2(n / 10);
        }

        public static int TichChuSo2(int n)
        {
            if (n / 10 == 0)
                return n;
            return n % 10 * TichChuSo2(n / 10);
        }

        //Bài 47: Hãy tính tổng các chữ số chẵn của số nguyên dương n
        public static int TongChuSoChan(int n)
        {
            int r, Tong = 0;
            while (n != 0)
            {
                r = n % 10; 
                if (r % 2 == 0)
                    Tong += r;
                n /= 10;
            }
            return Tong;
        }

        //Bài 48: Hãy tính tích các chữ số lẻ của số nguyên dương n
        public static int TichChuSoLe(int n)
        {
            int r, Tich = 1;
            while (n != 0)
            {
                r = n % 10;
                if (r % 2 != 0)
                    Tich *= r;
                n /= 10;
            }
            return Tich;
        }

        //Bài 50: Hãy tìm số đảo ngược của số nguyên dương n
        public static int SoDao(int n)
        {
            int r, sodao = 0;
            while (n != 0)
            {
                r = n % 10;
                n /= 10;
                sodao = sodao * 10 + r;
            }
            return sodao;
        }

        //Bài 51: Tìm chữ số lớn nhất của số nguyên dương n
        public static int ChuSoLonNhat(int n)
        {
            int r;
            int kq = 0;
            do
            {
                r = n % 10;
                n /= 10;
                if (r > kq)
                    kq = r;
            }
            while (n != 0);
            return kq;
        }

        //Bài 52: Tìm chữ số nhỏ nhất của số nguyên dương n
        public static int ChuSoNhoNhat(int n)
        {
            int r;
            int kq = 9;
            do
            {
                r = n % 10;
                n /= 10;
                if (r < kq)
                    kq = r;
            }
            while (n != 0);
            return kq;
        }

        //Dem so luong chu so x co trong 1 so nguyen duong N
        public static int SoLuongChuSo(int N, int x)
        {
            int r;
            int dem = 0;
            do
            {
                r = N % 10;
                N /= 10;
                if (r == x)
                    dem++;
            }
            while (N != 0);
            return dem;
        }

        //Bài 56: Hãy kiểm tra số nguyên dương n có toàn chữ số lẻ hay không
        public static bool KT_ChuSoLe(int n)
        {
            int r;
            do
            {
                r = n % 10;
                n /= 10;
                if (r % 2 == 0)
                    return false;
            }
            while (n != 0);
            return true;
        }

        //Bài 57: Hãy kiểm tra số nguyên dương n có toàn chữ số chẵn hay không
        public static bool KT_ChuSoChan(int n)
        {
            int r;
            do
            {
                r = n % 10;
                n /= 10;
                if (r % 2 != 0)
                    return false;
            }
            while (n != 0);
            return true;
        }

        //Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng (số gánh)
        public static bool LaSoDoiXung(int n)
        {
            if (n == SoDao(n))
                return true;
            else
                return false;
        }

        //Bài 60: Hãy kiểm tra các chữ số của số nguyên dương n có tăng dần từ trái sang phải hay không
        public static bool LaSoTangDan(int n)
        {
            //1 chu so => false
            if (n / 10 == 0)
                return false;
            //Khoi tao gia tri dau tien
            int r, t = n % 10;
            do
            {
                n /= 10;
                r = n % 10;
                if (r > t)
                    return false;
                t = r;
            }
            while (n != 0) ;
            return true;
        }

        //Bài 61: Hãy kiểm tra các chữ số của số nguyên dương n có giảm dần từ trái sang phải hay không
        public static bool LaSoGiamDan(int n)
        {
            //1 chu so => false
            if (n / 10 == 0)
                return false;
            //Khoi tao gia tri dau tien
            int r, t = n % 10;
            n /= 10;
            while (n != 0)
            {
                r = n % 10;
                if (r < t)
                    return false;
                t = r;
                n /= 10;
            }
            return true;
        }

        //Kiểm tra số nguyên là số Amstrong
        public static bool LaSoAmstrong(int N)
        {
            int k = DemChuSo(N);
            int Sum = 0, temp = N, r;
            while(temp !=0)
            {
                r = temp % 10;
                temp /= 10;
                Sum += Convert.ToInt32(Math.Pow(r, k));
            }
            if (Sum == N)
                return true;
            else
                return false;
        }
        //Bài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n
        public static double Bai67(double x, int n)
        {
            double y = -1;
            double kq = 0;
            for (int i = 1; i <= n; i++)
            {
                y *= - x;
                kq += y;
            }
            return kq;
        }

        //Bài 68: Tính S(x, n) = -x^2 + x^4  + … + (-1)^n * x^2n
        public static double Bai68(double x, int n)
        {
            double y = 1;
            double kq = 0;
            for (int i = 1; i <= n; i++)
            {
                y *= -x * x;
                kq += y;
            }
            return kq;
        }

        //Bài 69: Tính S(x, n) = x – x^3 + x^5 + … + (-1)^n * x^2n+1    //i=0..n
        public static double Bai69(double x, int n)
        {
            double y = x;
            double kq = y;
            for (int i = 1; i <= n; i++)
            {
                y *= -x * x;
                kq += y;
            }
            return kq;
        }

        //Bài 71: Tính S(x, n) = -x + x^2/(1 + 2) – x^3/(1 + 2 + 3) + … + (-1)^n * x^n/(1 + 2 +… + n)	//i = 1..n
        public static double Bai71(double x, int n)
        {
            double tu = -x, mau = 1;
            double kq = tu/mau;
            for (int i = 2; i <= n; i++)
            {
                tu = -tu * x;
                mau += i;
                kq += tu / mau;
            }
            return kq;
        }

        //Bài 72: Tính S(x, n) = –x + x^2/2! – x^3/3! + … + (-1)^n* x^n/n!	//i=1..n
        public static double Bai72(double x, int n)
        {
            double tu = -x, mau = 1;
            double kq = tu/mau;
            for (int i = 2; i <= n; i++)
            {
                tu = -tu * x;
                mau = mau * i;
                kq += tu / mau;
            }
            return kq;
        }

        //Bài 73: Tính S(x, n) = -1 + x^2/2! – x^4/4! + … + (-1)^(n+1) * x^2n/(2n)!	//i=0..n
        public static double Bai73(double x, int n)
        {
            double tu = -1, mau = 1;
            double kq = tu / mau;
            for (int i = 1; i <= n; i++)
            {
                tu = -tu * x * x;
                mau = mau * (2*i-1) * (2*i);
                kq += tu / mau;
            }
            return kq;
        }

        //Bài 74: Tính S(x, n) = –x + x^3/3! – x^5/5! + … + (-1)^(n+1) * x^(2n+1)/(2n+1)!	//i = 0..n
        public static double Bai74(double x, int n)
        {
            double tu = -x, mau = 1;
            double kq = tu/mau;
            for (int i = 1; i <= n; i++)
            {
                tu = -tu * x * x;
                mau = mau * (2*i) * (2*i+1);
                kq += tu / mau;
            }
            return kq;
        }

        //Bài 75: Kiểm tra số nguyên 4 byte có dạng 2^k hay không
        public static int Bai75(int n)
        {
            int k = 0;
            int x = 1;
            while (x < n)
            {
                k++;
                x *= 2;
            }
            if (x == n)
                return k;
            else
                return -1;
        }

        //Bài 76: Kiểm tra số nguyên 4 byte có dạng 3^k hay không
        public static int Bai76(int n)
        {
            int k = 0;
            int x = 1;
            while (x < n)
            {
                k++;
                x *= 3;
            }
            if (x == n)
                return k;
            else
                return -1;
        }

        //Kiểm tra số nguyên 4 byte có dạng 5^k hay không
        public static int SoNguyen5k(int n)
        {
            int k = 0;
            int x = 1;
            while (x < n)
            {
                k++;
                x *= 5;
            }
            if (x == n)
                return k;
            else
                return -1;
        }
               
    }
}
