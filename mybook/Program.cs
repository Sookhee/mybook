using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {

        class Book
        {
            public string title;
            public DateTime publishedDate;
            public string writer;
            public string publisher;
            public string publishingCompany;
            public string mainEditor;
            public string planner;
            public string editor;
            public string designer;
        }

        static void Main(string[] args)
        {
            Book mybook = new Book() {
                title = "PHP 프로그래밍 입문",
                publishedDate = new DateTime(2013, 5, 20),
                writer = "황재호",
                publisher = "김태헌",
                publishingCompany = "한빛아카데미(주)",
                mainEditor = "김현용",
                planner = "김이화",
                editor = "김이화",
                designer = "여동일"
            };

            Console.WriteLine("이름 : " + mybook.title);
            Console.WriteLine("초판 발행 : " + mybook.publishedDate);
            Console.WriteLine("지은이 : " + mybook.writer);
            Console.WriteLine("펴낸이 : " + mybook.publisher);
            Console.WriteLine("펴낸곳 : " + mybook.publishingCompany);
            Console.WriteLine("책임편집 : " + mybook.mainEditor);
            Console.WriteLine("기획 : " + mybook.planner);
            Console.WriteLine("편집 : " + mybook.editor);
            Console.WriteLine("디자인 : " + mybook.designer);
        }
    }
}
