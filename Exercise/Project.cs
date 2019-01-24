#define DEBUG
using System;
using System.Diagnostics;
namespace Project
{
    public class MyClass
    {
        [Conditional("DEBUG")]
        public static void Message(String msg)
        {
            System.Console.WriteLine(msg);

        }
    }

    class Test
    {
        static void function1()
        {
            MyClass.Message("In Function 1.");
            function2();
        }
        static void function2()
        {
            MyClass.Message("In Function 2.");
        }
        public static void Main(string[] args)
        {
            MyClass.Message("In Main function.");
            function1();
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute:System.Attribute
    {
        public readonly String url;
        public string Topic
        {
            get
            {
                return topic;
            }
            set
            {
                topic = value;
            }
        }
        public HelpAttribute(string url)
        {
            this.url = url;
        }
        private string topic;
    }

    [HelpAttribute("Information on the class MyClass")]
    class MyClass2
    {

    }
}

namespace AttributeApp1
{
    using Project;
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass2);
            object[] attributes = info.GetCustomAttributes(true);
            for(int i = 0;i<attributes.Length;i++){
                System.Console.WriteLine(attributes[i]);
            }
        }
    }
}

namespace IndexApplication
{
    class IndexedNames
    {
        private string[] nameList = new string[size];
        static public int size = 10;
        public IndexedNames(){
            for (int i = 0; i < size ; i++)
            {
                nameList[i] = "N.A.";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if(index>=0 && index<=size-1)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return (tmp);
            }
            set
            {
                if(index >= 0 && index <= size - 1)
                {
                    nameList[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rubic";
            for (int i = 0; i < IndexedNames.size; i++)
            {
                System.Console.WriteLine(names[i]);
                
            }
        }


    }
}