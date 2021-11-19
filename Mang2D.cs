//Code by: Chu Quang Thao - 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace TongHop_1
{
    class Mang2D
    {
        //Ham Nhap Mang 2D
        public static int[,] NhapMang_Int(int row, int col)
        {

            int[,] A = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"NHap A[{i},{j}]: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
        }

        public static double[,] NhapMang_Double(int row, int col)
        {
            
            double[,] A = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j< col; j++)
                {
                    Console.Write($"NHap A[{i},{j}]: ");
                    A[i,j] = double.Parse(Console.ReadLine());
                }               
            }
            return A;
        }

        //Tạo mảng 2D có giá trị ngẫu nhiên
        public static int[,] TaoMangRandom_Int(int row, int col)
        {
            int[,] A = new int[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    A[i, j] = r.Next(0,100);
                }
            }
            return A;
        }
        public static double[,] TaoMangRandom_Double(int row, int col)
        {
            double[,] A = new double[row, col];
            Random r = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    A[i, j] = Math.Round(r.NextDouble(),3);
                }
            }
            return A;
        }

        //Ham In Mang 2D
        public static void PrintMatrix(double[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i,j] + "\t");
                }
                Console.WriteLine();    
            }
        }
        public static void PrintMatrix(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //Duyệt mảng 2D bằng 1 vòng lặp
        public static void DuyetMatrix_1Loop(int[,] A)
        {
            int M = A.GetLength(0);
            int N = A.GetLength(1);
            for (int k = 0; k < M*N; k++)
            {
                int i = k / N;
                int j = k % N;
                Console.WriteLine(A[i, j]);
            }
        }

        //Chuyển mảng 2D thành 1D
        public static int[] Mang2DTo1D(int[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            int[] outArr = new int[M * N];
            for (int k = 0; k < M * N; k++)
                outArr[k] = A[k / N, k % N];
            return outArr;
        }

        //Viet ham tim gia tri lon nhat trong ma tran
        public static double Max(double[,] A)
        {
            double kq = A[0, 0];
            foreach (double x in A)
            {
                if (x > kq)
                    kq = x;
            }
            return kq;
        }

        //Đếm số lần xuất hiện của giá trị x trong ma trận
        public static int DemSoLanXuatHien(int[,] A, int x)
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == x)
                        dem++;
                }
            return dem;
        }

        //Bài 381: Tìm giá trị xuất hiện nhiều nhất
        public static int GTXuatHienNhieuNhat(int[,]A)
        {
            //Cải tiến 1: nếu A[i,j] đã được đếm trước đó thì bỏ qua
            //Cải tiến 2: nếu có 2 hoặc nhiều giá trị có số lần xuất hiện lớn nhất bằng nhau => liệt kê hết

            int kq = A[0, 0];
            int demMax = DemSoLanXuatHien(A, kq);
            for (int i=0; i < A.GetLength(0); i++)
                for (int j=0; j < A.GetLength(1); j++)
                {
                    int dem = DemSoLanXuatHien(A, A[i, j]);
                    if (dem > demMax)
                    {
                        demMax = dem;
                        kq = A[i, j];
                    }
                }
            return kq;
        }

        public static double TongGTBien(double[,] A)
        {
            double kq = 0;
            int M = A.GetLength(0);
            int N = A.GetLength(1);
            //Tong dong 0 & dong cuoi
            for (int j = 0; j < N; j++)
            {
                kq += A[0, j] + A[M-1, j];
            }
            //Tong phan tu cot dau & cuoi
            for (int i = 1; i < M-1; i++)
            {
                kq += A[i, 0] + A[i, N - 1];
            }
            return kq;
        }

        //Bài 330: Hãy biến đổi ma trận số thực bằng cách thay các giá trị bằng giá trị nguyên gần nó nhất
        public static int[,] MatrixNguyenGanNhat(double[,] A)
        {
            int[,] X = new int[A.GetLength(0), A.GetLength(1)];
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    X[i, j] = (int)(A[i, j] + 0.5);
                }
            return X;
        }

        //Xoa 1 Dong trong matrix (thu tu: 0,1,...)
        public static double[,] DeleteRow(double[,] A, int row)
        {
            int M = A.GetLength(0);
            int N = A.GetLength(1);
            double[,] res = new double[M-1, N];          
            int x = 0;
            for(int i = 0; i<M; i++)
            {
                if (i == row)
                    continue;
                for (int j = 0; j < N; j++)
                {
                    res[x, j] = A[i, j];
                }
                x++;
            }
            return res;
        }

        //Xoa 1 Cot trong matrix (thu tu: 0,1,...)
        public static double[,] DeleteColumn(double[,] A, int col)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] res = new double[m, n-1];
            int y = 0;            
            for (int j = 0; j < n; j++)
            {
                if (j == col)
                    continue;
                for (int i = 0; i < m; i++)
                {
                    res[i, y] = A[i, j];
                }
                y++;
            }
            return res;
        }

        //Minor Matrix
        public static double[,] Minor(double[,] A, int row, int col)
        {
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] res = new double[m - 1, n - 1];
            int x = 0;
            for (int i = 0; i < m; i++)
            {
                if (i == row)
                    continue;
                int y = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == col)
                        continue;
                    res[x, y] = A[i, j];
                    y++;
                }
                x++;
            }
            return res;
        }

        //Tổng 2 ma trận
        public static double[,] TongMatrix(double[,] A, double[,] B)
        {
            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
                throw new Exception("Error!");
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] res = new double[m, n];
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = A[i, j] + B[i, j];
                }
            }
            return res;
        }

        //Hiệu 2 ma trận
        public static double[,] HieuMatrix(double[,] A, double[,] B)
        {
            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
                throw new Exception("Error!");
            int m = A.GetLength(0);
            int n = A.GetLength(1);
            double[,] res = new double[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i, j] = A[i, j] - B[i, j];
                }
            }
            return res;
        }

        //Tích 2 ma trận
        public static double[,] TichMatrix(double[,] A, double[,] B)
        {
            if (A.GetLength(1) != B.GetLength(0))
                throw new Exception("Error");
            int M = A.GetLength(0);
            int N = A.GetLength(1);
            int P = B.GetLength(1);
            double[,] res = new double[M, P];
            for (int i = 0; i < M; i++)
                for (int k = 0; k < P; k++)
                    for (int j = 0; j < N; j++)
                        res[i, k] += A[i, j] * B[j, k];
            return res;
        }

        //Nhân ma trận với 1 số
        public static double[,] NhanMatrix(double[,] A, double x)
        {
            double[,] res = new double[A.GetLength(0), A.GetLength(1)];
            for(int i = 0; i < res.GetLength(0); i++)
                for (int j = 0; j < res.GetLength(1); j++)
                    res[i, j] = A[i, j] * x;
            return res;
        }

        //Hoan doi vi tri 2 phan tu trong Matrix
        public static void HoanVi(double [,] Arr, int row1, int col1, int row2, int col2)
        {
            double t = Arr[row1, col1];
            Arr[row1, col1] = Arr[row2, col2];
            Arr[row2, col2] = t;
        }

        //Sap xep Matrix
        public static void SortMatrix(double[,] A, bool ascending = true)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            for (int i=0; i < M; i++)
                for (int j=0; j < N; j++)
                {                    
                    //Sap xep tren dong thu i
                    for (int jj = j+1; jj < N; jj++)
                    {
                        if (ascending)
                        {
                            if (A[i, j] > A[i, jj])
                                HoanVi(A, i, j, i, jj);
                        }
                        else
                        {
                            if (A[i, j] < A[i, jj])
                                HoanVi(A, i, j, i, jj);
                        }
                    }
                    //Sap xep tren cac dong > i
                    for (int ii = i+1; ii < M; ii++)
                    {
                        for (int jj = 0; jj < N; jj++)
                        {
                            if (ascending)
                            {
                                if (A[i, j] > A[ii, jj])
                                    HoanVi(A, i, j, ii, jj);
                            }
                            else
                            {
                                if (A[i, j] < A[ii, jj])
                                    HoanVi(A, i, j, ii, jj);
                            }
                        }
                    }                    
                }
        }
        public static void SortMatrix2(double[,] A, bool ascending = true)
        {
            int M = A.GetLength(0), N = A.GetLength(1);            
            for (int i = 0; i < M*N - 1; i++)
            {
                for (int j = i + 1; j < M*N; j++)
                {
                    if (ascending) 
                    {
                        if (A[j / N, j % N] < A[i / N, i % N])
                            HoanVi(A, i / N, i % N, j / N, j % N);
                    }
                    else
                    {
                        if (A[j / N, j % N] > A[i / N, i % N])
                            HoanVi(A, i / N, i % N, j / N, j % N);
                    }                  
                }
            }
        }

        //Tạo Matrix con
        public static double[,] SubMatrix(double[,] A, int StartRow, int StartColumn, int LengthRow, int LengthColumn)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            if (LengthRow > M - StartRow)
                LengthRow = M - StartRow;
            if (LengthColumn > N - StartColumn)
                LengthColumn = N - StartColumn;
            double[,] X = new double[LengthRow, LengthColumn];
            for (int r = 0; r < LengthRow; r++)
                for (int c = 0; c < LengthColumn; c++)
                    X[r, c] = A[StartRow + r, StartColumn + c];
            return X;
        }

        //Liệt kê các matrix con
        public static void PrintSubMatrix(double[,] A)
        {
            Console.WriteLine("Cac Ma tran con:");
            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    for (int lr = 1; lr <= A.GetLength(0)-i; lr++)
                        for (int lc = 1; lc <= A.GetLength(1)-j; lc++)
                        {
                            double[,] sub = SubMatrix(A, i, j, lr, lc);
                            PrintMatrix(sub);
                            Console.WriteLine("---");
                        }
        }

        //Ma trận chuyển vị
        public static double[,] Transpose(double[,] A)
        {
            double [,] X = new double[A.GetLength(1), A.GetLength(0)];
            for (int i = 0; i < X.GetLength(0); i++)
                for (int j = 0; j < X.GetLength(1); j++)
                    X[i, j] = A[j, i];
            return X;
        }

        //Xoay ma trận 180°
        public static double[,] XoayMatrix180(double[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            double[,] X = new double[M,N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    X[i, j] = A[M-1-i, N-1-j];
            return X;
        }
		
        //Xoay ma trận 90°clockwise
        public static double[,] XoayMatrix90(double[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            double[,] X = new double[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    X[i, j] = A[M-1-j, i];
            return X;
        }

        //Xoay ma trận 270° (90° anti-clockwise
        public static double[,] XoayMatrix270(double[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            double[,] X = new double[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    X[i, j] = A[j, N-1-i];
            return X;
        }

        public static double[,] XoayMatrix0(double[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            double[,] X = new double[N, M];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    X[i, j] = A[M-1-j, N-1-i];
            return X;
        }
		
        //Chiếu gương Đứng
        public static double[,] ChieuGuongDung(double[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            double[,] X = new double[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    X[i, j] = A[i, N-1-j];
            return X;
        }

        //Chiếu gương Ngang
        public static double[,] ChieuGuongNgang(double[,] A)
        {
            int M = A.GetLength(0), N = A.GetLength(1);
            double[,] X = new double[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    X[i, j] = A[M-1-i, j];
            return X;
        }

        //Xác định phần tử Aij trong ma trận có phải Cực Đại
        public static bool LaGiaTriCucDai(double[,] A, int i, int j)
        {
            int k1 = i - 1, k2 = i + 1, l1 = j - 1, l2 = j + 1;
            if (k1 < 0)
                k1 = 0;
            if (k2 >= A.GetLength(0))
                k2 = A.GetLength(0) - 1;
            if (l1 < 0)
                l1 = 0;
            if (l2 >= A.GetLength(1))
                l2 = A.GetLength(1) - 1;
            for (int k = k1; k <= k2; k++)
                for (int l = l1; l <= l2; l++)
                    if (k != i || l != j)
                        if (A[i, j] <= A[k, l])
                            return false;
            return true;
        }

        //Xác định phần tử Aij trong ma trận có phải Cực Tiểu
        public static bool LaGiaTriCucTieu(double[,] A, int i, int j)
        {
            int k1 = i - 1, k2 = i + 1, l1 = j - 1, l2 = j + 1;
            if (k1 < 0)
                k1 = 0;
            if (k2 >= A.GetLength(0))
                k2 = A.GetLength(0) - 1;
            if (l1 < 0)
                l1 = 0;
            if (l2 >= A.GetLength(1))
                l2 = A.GetLength(1) - 1;
            for (int k = k1; k <= k2; k++)
                for (int l = l1; l <= l2; l++)
                    if (k != i || l != j)
                        if (A[i, j] >= A[k, l])
                            return false;
            return true;
        }

        //Xác định phần tử Aij trong ma trận có phải Cực Trị (Cực Đại hoặc Cực Tiểu)
        public static bool LaGiaTriCucTri(double[,] A, int i, int j)
        {
            bool cdai = LaGiaTriCucDai(A, i, j), ctieu = LaGiaTriCucTieu(A, i, j);
            return (cdai || ctieu);
        }

        //Bài 344(*): Đếm số lượng giá trị có trong ma trận các số thực.
        //Chú ý: Nếu có k phần tử (k >= 1) trong ma trận bằng nhau thì ta chỉ tính là 1
        public static int SoLuongGiaTri(double[,] A)
        {
            int dem = 1;
            int M = A.GetLength(0), N = A.GetLength(1);
            for (int i = 1; i < M * N; i++)
            {
                bool dadem = false;
                //Duyệt các phần tử trước k, tìm phần tử trùng
                for (int j = 0; j < i; j++)
                {
                    if (A[j / N, j % N] == A[i / N, i % N])
                    {
                        dadem = true;
                        break; 
                    }
                }
                if (!dadem)
                    dem++;
            }
            return dem;    
        }

        //Kiểm tra phần tử Aij có lớn nhất trên dòng
        public static bool LaLonNhatTrenDong(double[,] A, int i, int j)
        {
            for (int l = 0; l < A.GetLength(1); l++)
                if (l != j)
                    if (A[i, j] < A[i, l])
                        return false;
            return true;
        }

        //Kiểm tra phần tử Aij có lớn nhất trên cột
        public static bool LaLonNhatTrenCot(double[,] A, int i, int j)
        {
            for (int k = 0; k < A.GetLength(0); k++)
                if (k != i)
                    if (A[i, j] < A[k, j])
                        return false;
            return true;
        }

        //Kiểm tra phần tử Aij có lớn nhất trên đường chéo 1
        public static bool LaLonNhatTrenDCheo1(double[,] A, int i, int j)
        {
            int x = 1;
            while (i-x >= 0 && j-x >= 0)
            {
                if (A[i, j] < A[i - x, j - x])
                    return false;
                x++;
            }
            x = 1;
            while (i+x < A.GetLength(0) && j+x < A.GetLength(1))
            {
                if (A[i, j] < A[i + x, j + x])
                    return false;
                x++;
            }
            return true;
        }

        //Kiểm tra phần tử Aij có lớn nhất trên đường chéo 2
        public static bool LaLonNhatTrenDCheo2(double[,] A, int i, int j)
        {
            int x = 1;
            while (i + x < A.GetLength(0) && j - x >=0)
            {
                if (A[i, j] < A[i + x, j - x])
                    return false;
                x++;
            }
            x = 1;
            while (i - x >= 0 && j + x < A.GetLength(1))
            {
                if (A[i, j] < A[i - x, j + x])
                    return false;
                x++;
            }
            return true;
        }
       
        //Kiểm tra phần tử Aij có nhỏ nhất trên dòng
        public static bool LaNhoNhatTrenDong(double[,] A, int i, int j)
        {
            for (int l = 0; l < A.GetLength(1); l++)
                if (l != j)
                    if (A[i, j] > A[i, l])
                        return false;
            return true;
        }

        //Kiểm tra phần tử Aij có nhỏ nhất trên cột
        public static bool LaNhoNhatTrenCot(double[,] A, int i, int j)
        {
            for (int k = 0; k < A.GetLength(0); k++)
                if (k != i)
                    if (A[i, j] > A[k, j])
                        return false;
            return true;
        }

        //Kiểm tra phần tử Aij là giá trị "Hoàng hậu"
        public static bool LaHoangHau(double[,] A, int i, int j)
        {
            return (LaLonNhatTrenCot(A, i, j) && LaLonNhatTrenDong(A, i, j)
                && LaLonNhatTrenDCheo1(A, i, j) && LaLonNhatTrenDCheo2(A, i, j));
        }

        public static bool LaYenNgua(double[,] A, int i, int j)
        {
            return (LaLonNhatTrenDong(A, i, j) && LaNhoNhatTrenCot(A, i, j));
        }
    }
}
