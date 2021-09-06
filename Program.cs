using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace QuestionManage
{
    class Program
    {
        static int choose;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowMenu();
        }

        static void Menu()
        {
            WriteLine("--Chương trình quản lý đề thi----");
            WriteLine("=================================");
            WriteLine("1. Quản lý câu hỏi/trả lời.");
            WriteLine("2. Quản lý đề thi");
        }

        public void ShowMenu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            MenuQuestion menuQuestion = new MenuQuestion();
            do
            {
                Menu();
                choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Clear();
                        menuQuestion.MenuQuestions();
                        break;
                    case 2:
                        Clear();
                        menuQuestion.MenuTest();
                        break;
                    case 3:
                        Console.WriteLine("Bye!!! ");
                        break;
                    default:
                        Console.WriteLine("Bạn Chọn Sai Vui Lòng Chọn Lại !!! ");
                        break;
                }
            } while (choose != 3);
        }
    }

}

