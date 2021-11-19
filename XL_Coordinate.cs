//Code by: Chu Quang Thao - 2021
using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2021_04_17
{
    public struct Point
    {
        
        //Fields
        public double x; public double y; 
        //Properties => nên sử dụng cho OOP
        //public double X { get; set; }
        //public double Y { get; set; }

        //Constructor
        public Point(double x, double y)
        {
            this.x = x; this.y = y;
        }

        //struct's Method => gọi sau khi tạo đối tượng struct
        public void SetOrigin()
        {
            x = 0; y = 0;
        }
        public override string ToString() => $"({x},{y})";
        
    }
    public struct TamGiac
    {
        //Points - Properties
        public Point PointA { get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }

        //Lines - Fields
        public readonly double lineA;
        public readonly double lineB;
        public readonly double lineC;

        //Constructor
        public TamGiac(Point A, Point B, Point C)
        {
            PointA = A;
            PointB = B;
            PointC = C;
            lineA = Coordinate.TinhKhoangCach(PointB, PointC);
            lineB = Coordinate.TinhKhoangCach(PointA, PointC);
            lineC = Coordinate.TinhKhoangCach(PointA, PointB);
        }
        public TamGiac(double xA, double yA, double xB, double yB, double xC, double yC)
        {
            PointA = new Point(xA, yA);
            PointB = new Point(xB, yB);
            PointC = new Point(xC, yC);
            lineA = Coordinate.TinhKhoangCach(PointB, PointC);
            lineB = Coordinate.TinhKhoangCach(PointA, PointC);
            lineC = Coordinate.TinhKhoangCach(PointA, PointB);
        }

        //Kiểm tra hợp lệ
        public bool TamGiacHopLe()
        {
            if ((lineA + lineB > lineC) && (lineB + lineC > lineA) && (lineC + lineA > lineB))
                return true;
            else return false;
        }
    }
    public struct DaGiac
    {
        //Quy uoc: Đa giác là tập hợp các điểm (số điểm > 2)
        public List<Point> Points;
        public DaGiac(List<Point> points)
        {
            Points = points;
        }

    }

    /// <summary>
    /// 
    /// </summary>
    class Coordinate
    {
        //Method of class
        public static Point NhapDiem()
        {
            Point point = new Point();
            Console.Write("Nhap Toa do X: ");
            point.x = double.Parse(Console.ReadLine());
            Console.Write("Nhap Toa do Y: ");
            point.y = double.Parse(Console.ReadLine());
            return point;
        }

        public static double TinhKhoangCach(Point A, Point B)
        {
            return Math.Sqrt((A.x - B.x) * (A.x - B.x) + (A.y - B.y) * (A.y - B.y));
        }

        public static TamGiac NhapTamGiac()
        {
            TamGiac t = new TamGiac();
            Console.WriteLine("Nhap dinh A");
            t.PointA = NhapDiem();
            Console.WriteLine("Nhap dinh B");
            t.PointB = NhapDiem();
            Console.WriteLine("Nhap dinh C");
            t.PointC = NhapDiem();
            return t;
        }
        public static double TinhChuViTamGiac(TamGiac t)
        {
            double res = -1;
            if (t.TamGiacHopLe())
            {
                res = t.lineA + t.lineB + t.lineC;
            }
            return res;
        }
        public static double TinhDienTichTamGiac(TamGiac t)
        {
            double res = 1;
            if (t.TamGiacHopLe())
            {
                double p = (t.lineA + t.lineB + t.lineC) / 2;
                res = Math.Sqrt(p * (p - t.lineA) * (p - t.lineB) * (p - t.lineC));
            }
            return res;
        }
        public static double TinhDienTichTamGiac2(TamGiac t)
        {
            double res = 1;
            if (t.TamGiacHopLe())
            {
                return Math.Abs((t.PointC.x - t.PointA.x) * (t.PointB.y - t.PointA.y)
                    - (t.PointB.x - t.PointA.x) * (t.PointC.y - t.PointA.y)) / 2;
            }
            return res;
        }

        public static double TinhChuViDaGiac(DaGiac d)
        {
            double res = 0;
            int j = d.Points.Count - 1;
            for (int i = 0; i < d.Points.Count; i++)
            {
                res += Coordinate.TinhKhoangCach(d.Points[i], d.Points[j]);
                j = i;
            }
            return res;
        }
        public static double TinhDienTichDaGiac(DaGiac d)
        {
            double res = 0;
            int j = d.Points.Count - 1;
            for (int i = 0; i < d.Points.Count; i++)
            {
                res += d.Points[i].x * d.Points[j].y - d.Points[j].x * d.Points[i].y;
                j = i;
            }
            return Math.Abs(res)/2;
        }
    }
}
