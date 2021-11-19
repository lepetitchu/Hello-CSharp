//Code by: Chu Quang Thao - 2021
using System;

namespace TongHop_1
{
    class XL_SoThuc
    {
        public static double Min(double a, double b)
        {
            if (a < b)
                return a;
            else
                return b;
        }

        public static double Max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static void HoanVi(ref double a, ref double b)
        {
            double t = a;
            a = b;
            b = t;
        }

        //Bài 99: Viết chương trình nhập vào 3 số thực. Hãy in 3 số ấy ra màn hình theo thứ tự tăng dần mà chỉ dùng tối đa 1 biến phụ
        public static void SapXep3So(ref double a, ref double b, ref double c)
        {
            if (b < a)
                HoanVi(ref a, ref b);
            if (c < a)
                HoanVi(ref a, ref c);
            if (c < b)
                HoanVi(ref b, ref c);
        }

        //Bài 97: Viết chương trình nhập 3 cạnh của 1 tam giác, cho biết đó là tam giác gì
        public static bool LaTamGiacDeu(double a, double b, double c)
        {
            if (a == b && b == c)
                return true;
            return false;
        }
        public static bool LaTamGiacCan(double a, double b, double c)
        {
            if (a == b || b == c || c == a)
                return true;
            return false;
        }
        public static bool LaTamGiacVuong(double a, double b, double c)
        {
            if (a * a + b * b == c * c)
                return true;
            return false;
        }
        public static string TamGiac(double a, double b, double c)
        {
            //Sap xep 3 canh theo thu tu tang dan
            XL_SoThuc.SapXep3So(ref a, ref b, ref c);
            //Kiem tra tam giac hop le
            if (a <= 0 || (b + a) <= c)
                return "Khong phai tam giac hop le";
            if (LaTamGiacDeu(a, b, c))
                return "La tam giac deu";
            bool can = LaTamGiacCan(a, b, c);
            bool vuong = LaTamGiacVuong(a, b, c);
            if (can && vuong)
                return "La tam giac vuong can";
            if (can)
                return "La tam giac can";
            if (vuong)
                return "La tam giac vuong";
            return "La tam giac binh thuong";
        }

        //Bài 113: Lập chương trình tính sin(x) với độ chính xác 0.00001 theo công thức: Sin(x) = x – x^3/3! + x^5/5! + … + (-1)^n * x^(2n+1)/(2n+1)!
        public static double Sin(double x)
        {
            double tu = x;
			double mau = 1;
			double kq = tu / mau;
			int i = 1;
            while(true)
            {
				tu = -tu * x * x;
				mau = mau * (2*i) * (2*i+1);				
				if (Math.Abs(tu/mau) < 0.000001)
					break;
                kq += tu/mau;
                i++;
            }
            return kq;
        }
      
    }
}
