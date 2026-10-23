using System;

class HinhChuNhat
{
    private double mChieuCao;
    private double mChieuRong;

    public HinhChuNhat()
    {
        mChieuCao = 1.0;
        mChieuRong = 1.0;
    }

    public HinhChuNhat(double chieuCao, double chieuRong)
    {
        mChieuCao = chieuCao;
        mChieuRong = chieuRong;
    }

    public double ChieuCao
    {
        get { return mChieuCao; }
        set { if (value > 0) mChieuCao = value; }
    }

    public double ChieuRong
    {
        get { return mChieuRong; }
        set { if (value > 0) mChieuRong = value; }
    }

    public double TinhChuVi()
    {
        return (mChieuCao + mChieuRong) * 2;
    }

    public double TinhDienTich()
    {
        return mChieuCao * mChieuRong;
    }

    public bool LaHinhVuong()
    {
        return mChieuCao == mChieuRong;
    }

    public void XuatThongTin()
    {
        Console.WriteLine("Chieu rong: {0} | Chieu cao: {1} | Dien tich: {2} | Chu vi: {3} | La hinh vuong: {4}",
            mChieuRong, mChieuCao, TinhDienTich(), TinhChuVi(), LaHinhVuong() ? "Co" : "Khong");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== BAI TAP 3.2: LOP HINH CHU NHAT ===");

        HinhChuNhat hcn1 = new HinhChuNhat(5.0, 10.0);
        Console.Write("Thong tin HCN 1: ");
        hcn1.XuatThongTin();

        HinhChuNhat hcn2 = new HinhChuNhat(4.0, 4.0);
        Console.Write("Thong tin HCN 2: ");
        hcn2.XuatThongTin();

        Console.ReadKey();
    }
}