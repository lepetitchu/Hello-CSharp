//Code by: Chu Quang Thao - 2021
using System;

namespace Bai_2021_04_17
{ 
    public struct PhanSo 
    {
        public int TuSo { get; set; }
        public int MauSo { get; set; }
        public PhanSo(int tuso, int mauso)
        {
            TuSo = tuso;
            MauSo = mauso;
            this = XL_PhanSo.PhSoToiGian(this);
        }
        public override string ToString()
        {
            return $"{TuSo}/{MauSo}";
        }
    }

    class XL_PhanSo
    {
        public static PhanSo NhapPhanSo()
        {
            Console.Write("Nhap Tu so: ");
            int t = int.Parse(Console.ReadLine());
            Console.Write("Nhap Mau so: ");
            int m = int.Parse(Console.ReadLine());
            return new PhanSo(t, m);
        }

        public static int UCLN(int A, int B)
        {
            if (B == 0)
                return A;
            return UCLN(B, A % B);
        }
        public static PhanSo PhSoToiGian(PhanSo p)
        {
            int ucln = UCLN(p.TuSo, p.MauSo);
            if (ucln == 1)
            {
                return p;
            }
            PhanSo res = new PhanSo
            {
                TuSo = p.TuSo / ucln,
                MauSo = p.MauSo / ucln
            };
            return res;
        }

        public static PhanSo CongPhSo(PhanSo a, PhanSo b)
        {
            int t = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            int m = a.MauSo * b.MauSo;
            return new PhanSo(t, m);
        }
        public static PhanSo TruPhSo(PhanSo a, PhanSo b)
        {
            int t = a.TuSo * b.MauSo - a.MauSo * b.TuSo;
            int m = a.MauSo * b.MauSo;
            return new PhanSo(t, m);
        }
        public static PhanSo NhanPhSo(PhanSo a, PhanSo b)
        {
            int t = a.TuSo * b.TuSo;
            int m = a.MauSo * b.MauSo;
            return new PhanSo(t, m);
        }
        public static PhanSo ChiaPhSo(PhanSo a, PhanSo b)
        {
            int t = a.TuSo * b.MauSo;
            int m = a.MauSo * b.TuSo;
            return new PhanSo(t, m);
        }
    }
}
