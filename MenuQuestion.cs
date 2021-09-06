using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;


namespace QuestionManage
{
    class MenuQuestion
    {
       
        
        List<Question> questions = new List<Question>();
        static int choose;
        public void MenuQuestions()
        { Console.OutputEncoding = Encoding.UTF8;
            Program program = new Program();
            do
            {
                Menu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Clear();
                        DisplayQuestion();
                        break;
                    case 2:
                        Clear();
                        Edit();
                        break;
                    case 3:
                        Clear();
                        Create();
                        break;
                    case 4:
                        Clear();
                        program.ShowMenu();
                        break;
                    default:
                        Console.WriteLine("Chọn lại");
                        break;
                }
            } while (choose != 4);
        }

        public static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("======Quản lý Câu hỏi/Trả lời=======");
            Console.WriteLine("1. Xem danh sách");
            Console.WriteLine("2. Cập nhật câu hỏi");
            Console.WriteLine("3. Tạo mới một câu hỏi");
            Console.WriteLine("4. Trờ về menu chính.");
        }
        public  void MenuTest()
        {
            Program program = new Program();
            do
            {
                Console.OutputEncoding = Encoding.UTF8;
                WriteLine("====Quản lý đề thi=================");
                WriteLine("1. Xem đề thi");
                WriteLine("2. Tạo đề thi");
                WriteLine("0. Trờ về menu chính.");
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Clear();


                        break;
                    case 2:
                        Clear();
                        CreateTest();
                        break;

                    case 3:
                        Clear();
                        program.ShowMenu();
                        break;
                    default:
                        Console.WriteLine("Chọn lại");
                        break;
                }
            } while (choose != 3);


        }


        public void Create()
        {
            Console.OutputEncoding = Encoding.UTF8;
            String choose;
            while (true)
            {
                Question question = new Question();
                question.Input();

                questions.Add(question);

                Console.WriteLine("Bạn Có Muốn Nhập Tiếp Không? Y/N");
                choose = Console.ReadLine();
                if (choose.Equals("N")) break;
            }
        }

        public void Edit()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập Mã Câu Hỏi Cần Sửa: ");
            string Id = Console.ReadLine();
            foreach (var item in questions)
            {
                if (item.MaCauHoi.Equals(Id))
                {
                    item.Edit();
                    break;
                }
                else
                {
                    Console.WriteLine("Ko TÌm Thấy Câu Hỏi!!!");
                }
            }
        }

        public void DisplayQuestion()
        {
            Console.OutputEncoding = Encoding.UTF8;
             Console.WriteLine("Tổng Số Các Câu Hỏi Là: {0}", questions.Count);
            foreach (var item in questions)
            {
               
                item.Display();
            }
        }
        public void CreateTest()
        {System.IO.FileStream fs = new System.IO.FileStream("D:\\Test.txt",FileMode.OpenOrCreate,FileAccess.Write,FileShare.Read);

            StreamWriter sw = new StreamWriter(fs);
            string a;
            foreach (var items in questions)
            { 
                a = items.CauHoi;
              sw.Write();
             }
              
           
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
 