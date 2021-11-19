//Code by: Chu Quang Thao - 2021
using System;

namespace TongHop_1
{
    class XL_Date
    {
        public static bool IsLeapYear(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            else
                return false;
        }

        public static int SoNgayTrongThang(int month, int year)
        {
            int kq;
            switch (month)
            {
                case 2:
                    if (IsLeapYear(year))
                        kq = 29;
                    else
                        kq = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    kq = 30;
                    break;
                default:
                    kq = 31;
                    break;
            }
            return kq;
        }

        //Kiem tra ngay-thang-nam nhap vao hop le
        public static bool NgayHopLe(int day, int month, int year) 
        {
            if (day <= 0 || month <= 0 || month > 12)
                return false;
            int ngay_thang = SoNgayTrongThang(month, year);
            if (day > ngay_thang)
                return false;
            return true;
        }

        public static void TimNgayKe(int ngay, int thang, int nam, out int ngayke, out int thangke, out int namke)
        {
            int ngay_thang = SoNgayTrongThang(thang, nam);
            thangke = thang;
            namke = nam;
            ngayke = ngay + 1;
            if (ngayke > ngay_thang)
            {
                ngayke = 1;
                thangke = thang + 1;
                if (thangke > 12)
                {
                    thangke = 1;
                    namke = nam + 1;
                }
            }
        }

        public static void TimNgayTruoc(int ngay, int thang, int nam, out int ngaytr, out int thangtr, out int namtr)
        {
            int ngay_thang = SoNgayTrongThang(thang, nam);
            thangtr = thang;
            namtr = nam;           
            if (ngay == 1)
            {
                ngaytr = ngay_thang;
                if (thang == 1)
                {
                    thangtr = 12;
                    namtr = nam - 1;
                }
                else
                    thangtr = thang - 1;
            }
            else
            {
                ngaytr = ngay - 1;
            }
        }

        //Bài 104: Viết chương trình nhập ngày, tháng, năm.Tính xem ngày đó là ngày thứ bao nhiêu trong năm
        public static int NgayTrongNam(int day, int month, int year)
        {
            //Tinh tong so ngay cac thang truoc do 
            int temp = 0;
            for(int i = 1; i < month; i++)
            {
                temp += SoNgayTrongThang(i,year);
            }
            return temp + day;
        }

    }
}
