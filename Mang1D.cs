//Code by: Chu Quang Thao - 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace TongHop_1
{
    class Mang1D
    {
        //Ham Nhap Mang - So nguyen
        public static int[] NhapMang_Int()
        {
            Console.Write("Mang 1D So Nguyen - Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }

        //Ham Nhap Mang - So thuc
        public static double[] NhapMang_Double()
        {
            Console.Write("Mang 1D So Thuc - Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
            }
            return A;
        }

        //Ham Xuat Mang
        public static void XuatMang(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + "\t");
            Console.WriteLine();
        }
        public static void XuatMang(double[] A)
        {
            for (int i = 0; i < A.Length; i++)
                Console.Write(A[i] + "\t");
            Console.WriteLine();
        }
        public static void XuatMang_Line(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
                Console.WriteLine(A[i]);
        }
        public static void XuatMang_Line(double[] A)
        {
            for (int i = 0; i < A.Length; i++)
                Console.WriteLine(A[i]);
        }

        //Tim gia tri nho nhat
        public static double Min(double[] A)
        {
            double min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                    min = A[i];
            }
            return min;
        }
        public static int Min(int[] A)
        {
            int min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                    min = A[i];
            }
            return min;
        }

        //Tìm vị trí có giá trị nhỏ nhất
        public static int ViTriMin(double[] A)
        {
            int v = 0;
            double min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    v = i;
                }
            }
            return v;
        }
        public static int ViTriMin(int[] A)
        {
            int v = 0;
            int min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    v = i;
                }
            }
            return v;
        }

        //Tim gia tri lon nhat
        public static double Max(double[] A)
        {
            double max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                    max = A[i];
            }
            return max;
        }
        public static int Max(int[] A)
        {
            int max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                    max = A[i];
            }
            return max;
        }

        //Tìm vị trí có giá trị lớn nhất
        public static int ViTriMax(double[] A)
        {
            int v = 0;
            double max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    v = i;
                }
            }
            return v;
        }

        //Hoán đổi vị trí 2 phần tử trong mảng
        public static void HoanVi(double[] A, int i, int j)
        {
            double t = A[i];
            A[i] = A[j];
            A[j] = t;
        }

        //Tinh Tong cac phan tu trong mang
        public static int TinhTong(int[] A)
        {
            int S = 0;
            for (int i = 0; i < A.Length; i++)
                S += A[i];
            return S;
        }

        //Tinh trung binh cong cac phan tu duong
        public static double Tinh_TBCDuong(int[] A)
        {
            double kq;
            double Tong = 0;
            int dem = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    Tong += A[i];
                    dem++;
                }
            }
            if (dem > 0)
                kq = Tong / dem;
            else
                kq = 0;
            return kq;
        }

        //Bài 135: Viết hàm tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về -1
        public static double TimSoDuongDauTien(double[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                    return A[i];
            }
            return -1;
        }

        //Bài 136: Tìm số chẵn cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì trả về -1
        public static int TimSoChanCuoiCung(int[] A)
        {
            for (int i = A.Length - 1; i >= 0; i--)
            {
                if (A[i] % 2 == 0)
                    return A[i];
            }
            return -1;
        }

        //Bài 138: Tìm vị trí của giá trị chẵn đầu tiên trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì sẽ trả về -1
        public static int TimVTChanDauTien(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        //Bài 140: Hãy tìm giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì sẽ trả về -1
        public static double TimGTDuongMin(double[] A)
        {
            int i, j;
            double min = -1;
            //Tim gia tri duong dau tien
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    min = A[i];
                    break;
                }
            }
            //Tim phan con lai]
            if (min != -1)
                for (j = i+1; j < A.Length; j++)
                {
                    if (A[j] > 0 && A[j] < min)
                        min = A[j];
                }
            return min;
        }

        //Bài 141: Hãy tìm vị trí giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về  -1
        public static int TimVTDuongMin(double[] A)
        {
            int i, j, v = -1;
            double min = -1;
            //Tim gia tri duong dau tien
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    v = i;
                    min = A[i];
                    break;
                }
            }
            //Tim phan con lai]
            if (v != -1)
                for (j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > 0 && A[j] < min)
                    {
                        v = j;
                        min = A[j];
                    }
                }
            return v;
        }

        //Bài 153: Hãy tìm giá trị chẵn nhỏ nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số chẵn thì trả về -1
        public static int TimGTChanMin(int[] A)
        {
            int i, j, min = -1;
            //Tim so chan dau tien trong mang
            for (i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    min = A[i];
                    break;
                }
            }
            //Tim phan con lai
            if (min != -1)
                for (j = i+1; j < A.Length; j++)
                {
                    if (A[j] % 2 == 0 && A[j] < min)
                        min = A[j];
                }
            return min;
        }

        //Bài 154: Hãy tìm vị trí giá trị âm nhỏ nhất trong mảng các số thực.Nếu mảng không có số âm thì trả về -1
        public static int TimVTAmMin(double[] A)
        {
            double min = 0;
            int v = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < 0 && A[i] < min)
                {
                    min = A[i];
                    v = i;
                }
            }
            return v;
        }

        //Bài 155: Hãy tìm giá trị trong mảng các số thực xa giá trị x nhất
        public static double GTXaNhatTrongMang(double[] A, double x)
        {
            int v = 0;
            double t = Math.Abs(A[0] - x);
            for (int i = 1; i < A.Length; i++)
            {
                double delta = Math.Abs(A[i] - x);
                if (delta > t)
                {
                    v = i;
                    t = delta;
                }
            }
            return A[v];
        }

        //Bài 156: Hãy tìm giá trị trong mảng các số thực gần giá trị x nhất
        public static double GTGanNhatTrongMang(double[] A, double x)
        {
            int v = 0;
            double t = Math.Abs(A[0] - x);
            for (int i = 1; i < A.Length; i++)
            {
                double delta = Math.Abs(A[i] - x);
                if (delta < t)
                {
                    v = i;
                    t = delta;
                }
            }
            return A[v];
        }

        //Bài 158: Cho mảng 1 chiều các số thực, hãy tìm giá trị x sao cho đoạn [-x, x] chứa tất cả các giá trị trong mảng
        public static double Bai158(double[] A)
        {
            double x1 = Math.Abs(Mang1D.Max(A));
            double x2 = Math.Abs(Mang1D.Min(A));
            return XL_SoThuc.Max(x1, x2);
        }

        //Bài 160: Cho mảng 1 chiều các số thực, hãy tìm giá trị âm cuối cùng lớn hơn -1. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về -1
        public static double TimGTAmCuoiCung(double[] A)
        {
            for (int i = A.Length -1; i >= 0; i--)
            {
                if (A[i] < 0 && A[i] > -1)
                    return A[i];
            }
            return -1;
        }

        //Bài 161: Cho mảng 1 chiều các số nguyên, hãy tìm giá trị đầu tiên nằm trong khoảng [x, y] cho trước. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về -1
        public static double TimGTTrongKhoang(double[] A, double x, double y)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= x && A[i] <= y)
                    return A[i];
            }
            return -1;
        }

        //Bài 162: Cho mảng 1 chiều các số thực.Hãy viết hàm tìm một vị trí trong mảng thỏa 2 điều kiện: có 2 giá trị lân cận và giá trị tại đó bằng tích 2 giá trị lân cận. Nếu mảng không tồn tại giá trị như vậy thì trả về giá trị -1
        public static int TimVTTichLanCan(double[] A)
        {
            if (A.Length == 3)
                return -1;
            for (int i = 1; i < A.Length-1; i++)
            {
                if (A[i] == A[i - 1] * A[i + 1])
                    return i;
            }
            return -1;
        }
        
        //Bài 165: Cho mảng 1 chiều các số nguyên. Hãy tìm giá trị đầu tiên có chữ số đầu tiên là chữ số lẻ
        public static int TimGTChuSoDauTienLe(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                string chuoiso = A[i].ToString();
                if (Convert.ToInt32(chuoiso[0]) % 2 != 0)
                    return A[i];
            }
            return 0;
        }

        //Bài 167: Hãy tìm giá trị thỏa điều kiện toàn chữ số lẻ và là giá trị lớn nhất thỏa điều kiện ấy trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về 0
        public static int TimGTToanChuSoLeMax(int[] A)
        {
            int i, j, v = -1, min = 0;
            //Tim gia tri toan chu so le dau tien
            for (i = 0; i < A.Length; i++)
            {
                if (XL_SoNguyen.KT_ChuSoLe(A[i]))
                {
                    v = i;
                    min = A[i];
                    break;
                } 
            }
            //Duyet phan con lai cua mang
            if (v!= -1)
            {
                for (j = i+1; j < A.Length; j++)
                {
                    if (XL_SoNguyen.KT_ChuSoLe(A[j]) && A[j] > min)
                    {
                        v = j;
                        min = A[j];
                    }
                }
            }
            return min;
        }

        //Bài 168: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm giá trị lớn nhất trong mảng có dạng 5^k. Nếu mảng khong tồn tại giá trị 5^k thì hàm sẽ trả về 0
        public static int Bai168(int[] A)
        {
            int kq = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int k = XL_SoNguyen.SoNguyen5k(A[i]);
                if (k == -1)
                    continue;
                if (A[i] > kq)
                    kq = A[i];
            }
            return kq;
        }

        //Bài 169: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số chẵn nhỏ nhất lớn hơn mọi giá trị có trong mảng
        public static int Bai169(int[] A)
        {
            int max = Mang1D.Max(A);
            if (max % 2 == 0)
                return max + 2;
            else
                return max + 1;
        }

        //Bài 170: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số nguyên tố nhỏ nhất lớn hơn mọi giá trị có trong mảng
        public static int Bai170(int[] A)
        {
            int max = Mang1D.Max(A);
            int x = max + 1;
            while (!XL_SoNguyen.LaSoNguyenTo(x))
            {
                x++;
            }
            return x;
        }

        //Bài 171: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm ước chung lớn nhất của tất cả các phần tử trong mảng
        public static int UCLN_Mang(int[] A)
        {
            if (A.Length < 2)
                return -1;
            int x = XL_SoNguyen.UCLN(A[0], A[1]);
            for (int i = 2; i < A.Length; i++)
            {
                x = XL_SoNguyen.UCLN(x, A[i]);
            }
            return x;
        }

        //Bài 172: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm bội chung nhỏ nhất của tất cả các phần tử trong mảng
        public static int BCNN_Mang(int[] A)
        {
            if (A.Length < 2)
                return -1;
            int x = XL_SoNguyen.BCNN(A[0], A[1]);
            for (int i = 2; i < A.Length; i++)
            {
                x = XL_SoNguyen.BCNN(x, A[i]);
            }
            return x;
        }

        //Bài 173 (*): Cho mảng 1 chiều các số nguyên. Hãy  viết hàm tìm CHỮ SỐ xuất hiện ít nhất trong mảng
        public static int ChuSoXHItNhat(int[] A)
        {
            int[] dem = new int[10];    //Mang chua so lan xuat hien cua moi chu so
            for (int i = 0; i < A.Length; i++)
            {
                //Tach chu so A[i]
                int r, n = A[i];
                do
                {
                    r = n % 10;
                    for (int j = 0; j < 10; j++)
                    {
                        if (r == j)
                            dem[j]++;
                    }
                    n /= 10;
                }
                while (n != 0);
            }
            //Tim dem[j]>0 & min
            int v=-1, min = Max(dem);
            for (int j = 0; j < 10; j++)
            {
                if (dem[j] > 0 && dem[j] < min)
                {
                    min = dem[j];
                    v = j;
                }
            }
            return v;
        }

        //Bài 230: Liệt kê tần suất xuất hiện các giá trị trong mảng (mỗi giá trị liệt kê 1 lần)
        public static void LietKeTanSuat(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                bool DaDem = false;
                //Kiểm tra giá trị đã được đếm tính từ đầu dãy đến vị trí i
                for (int j = 0; j < i; j++)
                {
                    if (A[j] == A[i])   //A[i] đã được đếm trước đó
                    {
                        DaDem = true;
                        break;
                    }
                }
                //Đếm A[i] NẾU chưa được đếm trước đó
                if (DaDem == false)
                {
                    int dem = 1;
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == A[i])
                            dem++;
                    }
                    Console.WriteLine($"{A[i]} xuat hien {dem} lan");
                }
            }
        }

        //Tạo mảng chỉ chứa giá trị đơn nhất từ mảng 1 chiều (mỗi giá trị liệt kê 1 lần)
        public static int[] MangDonNhat(int[] A)
        {
            int k = 0;
            int[] X = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                bool daDem = false;
                for (int j = 0; j < i; j++)
                {
                    if (A[j] == A[i])
                    {
                        daDem = true;
                        break;
                    }
                }
                if (daDem == false)
                {
                    X[k] = A[i];
                    k++;
                }
            }
            Array.Resize(ref X, k);
            return X;
        }

        //Bài 231: Hãy liệt kê các giá trị xuất hiện trong mảng 1 chiều các số nguyên đúng 1 lần
        public static void LietKeGiaTriMotLan(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                bool DaDem = false;
                for (int j = 0; j < A.Length; j++)
                {
                    if (j == i)
                        continue;
                    if (A[j] == A[i])
                    {
                        DaDem = true;
                        break;
                    }
                }
                if (DaDem == false)
                    Console.Write($"{A[i]}\t");
            }
            Console.WriteLine();
        }
        //Bài 232: Hãy liệt kê các giá trị xuất hiện trong dãy quá 1 lần.Lưu ý: mỗi giá trị liệt kê 1 lần
        public static void LietKeGiaTriQuaMotLan(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                bool DaDem = false;
                for (int j = 0; j < i; j++)
                {
                    if (A[j] == A[i])
                    {
                        DaDem = true;
                        break;
                    }
                }
                if (DaDem == false)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == A[i])
                        {
                            Console.Write($"{A[i]}\t");
                        }
                    }
                }
            }
            Console.WriteLine();
        }

        //Tìm vị trí xuất hiện giá trị x trong mảng
        public static int TimViTri(int[] A, int x)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == x)
                    return i;
            }
            return -1;
        }

        //Bài 235: Cho 2 mảng A, B. Liệt kê các giá trị chỉ xuất hiện 1 trong 2 mảng
        public static void Bai235(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length; i++)
            {
                //A[i] khong xuat hien trong B => Xuat A[i]
                if (TimViTri(B, A[i]) == -1)
                {
                    Console.WriteLine(A[i]);
                }
            }
            for (int j = 0; j < B.Length; j++)
            {
                //B[j] khong xuat hien trong A => Xuat B[j]
                if (TimViTri(A, B[j]) == -1)
                {
                    Console.WriteLine(B[j]);
                }
            }
        }

        //Sap xep mang tang dan - giam dan
        public static void Sort_Selection(double[] A, bool asc = true)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (asc)
                    {
                        if (A[j] < A[i])
                            HoanVi(A, i, j);
                    }
                    else
                    {
                        if (A[j] > A[i])
                            HoanVi(A, i, j);
                    }
                }
            }
        }

        public static void Sort_Bubble(double[] A)
        {
            for (int i = A.Length-1; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (A[j - 1] > A[j])
                        HoanVi(A, j-1, j);
                }
            }
        }

        //Sắp xếp mảng theo thứ tự số chẵn tăng dần => số lẻ tăng dần
        public static void Sort_ChanLe(double[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {
                    if ((A[i] % 2 == 0 && A[j] % 2 == 0) || (A[i] % 2 != 0 && A[j] % 2 != 0))
                    {
                        if (A[j] < A[i])
                            HoanVi(A, i, j);
                    }
                    else if (A[i] % 2 != 0 && A[j] % 2 == 0)
                        HoanVi(A, i, j);
                }
            }
        }
        //Sắp xếp mảng theo thứ tự số chẵn giảm dần => số lẻ tăng dần
        public static void Sort_ChanLe2(double[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[i] % 2 == 0 && A[j] % 2 == 0)
                    {
                        if (A[j] > A[i])
                            HoanVi(A, i, j);
                    }
                    else if (A[i] % 2 != 0 && A[j] % 2 != 0)
                    {
                        if (A[j] < A[i])
                            HoanVi(A, i, j);
                    }
                    else if (A[i] % 2 != 0 && A[j] % 2 == 0)
                        HoanVi(A, i, j);
                }
            }
        }

        //Bài 248: Kiểm tra mảng có tăng dần hay không
        public static bool MangTangDan(double[] A)
        {
            for(int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] > A[i + 1])
                    return false;
            }
            return true;
        }

        //Bài 249: Kiểm tra mảng có giảm dần hay không
        public static bool MangGiamDan(double[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                if (A[i] < A[i + 1])
                    return false;
            }
            return true;
        }

        //Bài 264: Trộn 2 mảng đã tăng thành 1 mảng được sắp xếp tăng dần
        public static double[] Tron2MangTang(double[]A, double[] B)
        {
            double[] X = new double[A.Length + B.Length];
            int i = 0, j = 0;
            do
            {
                if (i < A.Length && j < B.Length)
                {
                    if (A[i] < B[j])
                    {
                        X[i + j] = A[i];
                        i++;
                    }
                    else
                    {
                        X[i + j] = B[j];
                        j++;
                    }
                }
                else if (i == A.Length)
                {
                    X[i + j] = B[j];
                    j++;
                }
                else if (j == B.Length)
                {
                    X[i + j] = A[i];
                    i++;
                }
            }
            while (i < A.Length || j < B.Length);
            return X;
        }

        //Bài 265: Trộn 2 mảng đã tăng thành 1 mảng được sắp xếp giảm dần
        public static double[] Tron2MangGiam(double[] A, double[] B)
        {
            double[] X = new double[A.Length + B.Length];
            int i = 0, j = 0, k = A.Length + B.Length-1;
            while (i < A.Length || j < B.Length)
            {
                if (i < A.Length && j < B.Length)
                {
                    if (A[i] < B[j])
                    {
                        X[k] = A[i];
                        i++;
                        k--;
                    }
                    else
                    {
                        X[k] = B[j];
                        j++;
                        k--;
                    }
                }
                else if (i == A.Length)
                {
                    X[k] = B[j];
                    j++;
                    k--;
                }
                else if (j == B.Length)
                {
                    X[k] = A[i];
                    i++;
                    k--;
                }
            }           
            return X;
        }

        //Bài 266: Thêm 1 phần tử x vào mảng tại vị trí k
        public static void InsertItem(ref double[]A, double x, int k)
        {
            if (k < 0)
                k = 0;
            if (k > A.Length)
                k = A.Length;
            Array.Resize(ref A, A.Length + 1);
            for (int i = A.Length - 1; i > k; i--)
            {
                A[i] = A[i - 1];
            }
            A[k] = x;
        }

        //Bài 267: Viết hàm nhập mảng sao cho khi nhập xong thì giá trị trong mảng sắp xếp giảm dần
        public static double[] NhapMangTuGiam()
        {
            Console.Write("Mang 1D So Thuc - Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            Console.Write($"Nhap A[{0}]: ");
            A[0] = double.Parse(Console.ReadLine());
            //Nhap cac gia tri con lai
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
                //So sanh A[i] voi cac gia tri da co & sap xep
                for (int k = 0; k < i; k++)
                {
                    if (A[i] > A[k])
                    {
                        double t = A[i];
                        A[i] = A[k];
                        A[k] = t;
                    }                    
                }
            }
            return A;
        }

        public static double[] NhapMangTuGiam2()
        {
            Console.Write("Mang 1D So Thuc - Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            //Tao gia tri dau tien
            double[] A = new double[1];
            Console.Write($"Nhap A[{0}]: ");
            A[0] = double.Parse(Console.ReadLine());
            //Nhap cac gia tri con lai
            int i, j;
            for (i = 1; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                double x = double.Parse(Console.ReadLine());
                //So sanh x voi cac gia tri da co cua mang
                for (j = 0; j < A.Length; j++)
                {                    
                    if (x > A[j])
                    {
                        InsertItem(ref A, x, j);
                        break;
                    }                    
                }
                if (j == A.Length)
                    InsertItem(ref A, x, A.Length);
            }
            return A;
        }

        //Bài 270: Nhập mảng sau khi nhập xong đã tự sắp xếp tăng dần
        public static double[] NhapMangTuTang()
        {
            Console.Write("Mang 1D So Thuc - Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            //Nhap gia tri dau tien
            Console.Write($"Nhap A[{0}]: ");
            A[0] = double.Parse(Console.ReadLine());
            //Nhap cac gia tri con lai
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
                //So sanh A[i] voi cac gia tri phia truoc & sap xep
                for (int k = 0; k < i; k++)
                {
                    if (A[i] < A[k])
                    {
                        double t = A[i];
                        A[i] = A[k];
                        A[k] = t;
                    }
                }
            }
            return A;
        }
        public static double[] NhapMangTuTang2()
        {
            Console.Write("Mang 1D So Thuc - Nhap so phan tu: ");
            int n = int.Parse(Console.ReadLine());
            //Tao gia tri dau tien
            double[] A = new double[1];
            Console.Write($"Nhap A[{0}]: ");
            A[0] = double.Parse(Console.ReadLine());
            //Nhap cac gia tri con lai
            int i, j;
            for (i = 1; i < n; i++)
            {
                Console.Write($"Nhap A[{i}]: ");
                double x = double.Parse(Console.ReadLine());
                //So sanh x voi cac gia tri da co cua mang
                for (j = 0; j < A.Length; j++)
                {
                    if (x < A[j])
                    {
                        InsertItem(ref A, x, j);
                        break;
                    }
                }
                if (j == A.Length)
                    InsertItem(ref A, x, A.Length);
            }
            return A;
        }

        //Bài 271: Xóa 1 phần tử có chỉ số k trong mảng
        public static void DeleteItem(ref double[]A, int k)
        {
            for (int i = k; i < A.Length - 1; i++)
            {
                A[i] = A[i+1];
            }
            Array.Resize(ref A, A.Length - 1);            
        }

        //Tìm Mảng Con
        public static double[] SubArray(double[] A, int start, int length)
        {
            if (length > A.Length - start)
                length = A.Length - start;
            double[] X = new double[length];
            for (int j = 0; j < length; j++)
            {
                X[j] = A[j + start];
            }
            return X;               
        }

        public static void PrintSubArrays(double[] A)
        {
            Console.WriteLine("Cac Mang con:");
            for (int i = 0; i < A.Length; i++)
                for (int l = 1; l <= A.Length - i; l++)
                {
                    double[] sub = SubArray(A, i, l);
                    XuatMang(sub);
                }
        }
    }
}
