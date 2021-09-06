using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionManage
{
    class Question
    {
        string[] dapAn = new string[4];
        char[] dapAnDung = new char[4];
        string cauHoi;
        float diem;
        string maDanhMuc;
        string maCauhoi;


        string MaDanhMuc { get; set; }
        public string MaCauHoi { get; set; }
        public string CauHoi { get; set; }
        public float Diem { get; set; }
       
        public Question() { }
        public Question(string maDanhMuc, string maCauHoi, string cauHoi, float diem, string[] dapAn,char[] dapAnDung)
        {
            this.maDanhMuc = maDanhMuc;
            this.MaCauHoi = maCauHoi;
            this.cauHoi = cauHoi;
            this.diem = diem;
            this.dapAn = dapAn;
            this.dapAnDung = dapAnDung;
        }
        public void Input()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập Mã Danh Mục: ");
            maDanhMuc = Console.ReadLine();
            Console.Write("Nhập Mã Câu Hỏi: ");
            MaCauHoi = Console.ReadLine();
            Console.Write("Nhập Câu Hỏi: ");
            cauHoi = Console.ReadLine();
            Console.Write("Nhập Điểm: ");
            diem = float.Parse(Console.ReadLine());
            
            
            for(int i = 0; i <dapAnDung.Length; i++)
            {
                Console.Write("Nhập Đáp Án :  " );
                dapAn[i] = Console.ReadLine();
                
                Console.Write("Đáp Án  Đúng Hay Sai (D/S):  " );
                dapAnDung[i] = char.Parse(Console.ReadLine());

            }
        }

        public void Display()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Ma danh muc: {0}", maDanhMuc);
            Console.WriteLine("Ma Cau hoi: {0}", MaCauHoi);
            Console.WriteLine("Ten cau hoi: {0}", cauHoi);
            Console.WriteLine("Diem: {0}", diem);
            for (int i = 0; i < dapAnDung.Length; i++)
            {
                Console.WriteLine("Đáp Án:{0} ", dapAn[i]);
                Console.WriteLine("Đáp Án  Đúng Hay Sai (D/S): {0} ",dapAnDung[i]);
            }
            Console.WriteLine("");
        }

        public void Edit()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Câu Hỏi: ");
            cauHoi = Console.ReadLine();
            Console.WriteLine("Nhập Điểm: ");
            diem = float.Parse(Console.ReadLine());

            for (int i = 0; i < dapAnDung.Length; i++)
            {
                Console.WriteLine("Nhap dap an : ");
                dapAn[i] = Console.ReadLine();

                Console.Write("Đáp Án  Đúng Hay Sai (D/S):  ");
                dapAnDung[i] = char.Parse(Console.ReadLine());
            }
        }
    }
}
