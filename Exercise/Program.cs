using System;

namespace Exercise
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     Console.WriteLine("Hello World!");
        //     Program p = new Program();
        //     // p.readArray();
        //     // p.testString();
        //     // p.testStructure();
        //     // p.readEnum();
        //     // p.TestBox();
        //     // p.testLine();
        //     p.testRectangle();
        // }

        void readArray()
        {
            int[] n = new int[10];
            int i,j;
            // 初始化数组n的元素
            for(i = 0;i<10;i++){
                n[i] = i + 100;
            }
            // 输出每个数组元素的值
            for(j=0;j<10;j++)
            {
                Console.WriteLine("Element[{0}] = {1}",j,n[j]);
            }
        }

        void testString()
        {
            string fname,lname;
            fname = "xi";
            lname = "yangyang";
            string fullName = fname + lname;
            Console.WriteLine("Full Name:{0}",fullName);

            // 通过使用string构造函数
            char[] letters = {'H','e','l','l','o'};
            string greetings = new string(letters);
            Console.WriteLine("Greetings:{0}",greetings);
            // 方法返回字符串
            string[] sarray = {"Hello","From","Tutorials","Point"};
            string message = String.Join(" ",sarray);
            Console.WriteLine("Message:{0}",message);
            //用于转化值的格式化方法
            DateTime waiting = new DateTime(2012,10,10,17,58,1);
            string chat = String.Format("Message sent at {0:t} on {0:D}",waiting);
            Console.WriteLine("Message:{0}",chat);
            /*
            输出结果
            Hello World!
            Full Name:xiyangyang
            Greetings:Hello
            Message:Hello From Tutorials Point
            Message:Message sent at 17:58 on 2012年10月10日
             */
        }

        void testStructure()
        {
            Books book1;
            book1.title = "数据结构与算法分析";
            book1.author = "马克-艾伦-维斯";
            book1.subject = "编程基础";
            book1.bookId = 1;

            System.Console.WriteLine("book1 title: {0}",book1.title);
            System.Console.WriteLine("book1 author: {0}",book1.author);
            System.Console.WriteLine("book1 subject: {0}",book1.subject);
            System.Console.WriteLine("book1 bookId: {0}",book1.bookId);
        }

        //声明枚举变量
        enum Day{Sun,Mon,Tue,Wed,Thu,Fri,Sat};

        void readEnum()
        {
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            System.Console.WriteLine("Sun = {0}",x);
            System.Console.WriteLine("Fri = {0}",y);
        }

        void TestBox()
        {
            // Box box1 = new Box();
            // Box box2 = new Box();
            // double volume = 0.0;
            //box1 详述
            // box1.height = 5.0;
            // box1.length = 6.0;
            // box1.width = 3.0;
            //box2 详述
            // box1.height = 10.0;
            // box1.length = 12.0;
            // box1.width = 13.0;

            // volume = box1.height*box1.length*box1.width;
            // System.Console.WriteLine("box1 的体积：{0}",volume);
            // volume = box2.height*box2.length*box2.width;
            // System.Console.WriteLine("box2的体积：{0}",volume);



        }

        void testLine()
        {
            Line line = new Line();
            line.setLength(6.0);
            System.Console.WriteLine("线条的长度：{0}",line.getLength());
        }

        void testRectangle()
        {
            Rectangle rect = new Rectangle();
            rect.setWidth(5);
            rect.setHeight(7);
            System.Console.WriteLine("总面积：{0}",rect.getArea());
        }

    }
        //结构体测试 
        struct Books
        {
            public string title;
            public string author;
            public string subject;
            public int bookId;
        }

        class Box
        {
            // public double length;
            // public double width;

            // public double height;

            private double length;
            private double width;
            private double height;

            public void setLength(double len)
            {
                this.length = len;
            }
            public void setWidth(double width)
            {
                this.width = width;
            }
            public void setHeight(double height)
            {
                this.height = height;
            }

            public double getVolume()
            {
                return length*width*height;
            }
        }

        class Line
        {
            private double length;//线条长度
            public Line()
            {
                System.Console.WriteLine("对象已创建");
            }

            public void setLength(double len)
            {
                length = len;
            }

            public double getLength(){
                return length;
            }
        }

        class Shape
        {
            protected int width;
            protected int height;
            public void setWidth(int w)
            {
                this.width = w;
            }
            public void setHeight(int h)
            {
                this.height = h;
            }
        }

        // 派生类
        class Rectangle:Shape
        {
            public int getArea()
            {
                return (width*height);
            }
        }

    




}
