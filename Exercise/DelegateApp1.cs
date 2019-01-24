/**
    C#中的委托类似于C或C++中函数的指针，委托是存有对某个方法的引用的一种类型变量，引用可在运行时被改变
    委托特别用于实现事件和回调方法，所有的委托（Delegate）都派生自System.Delegate
    委托声明决定了可由该委托引用的方法，委托可指向一个与其具有相同标签的方法
    public delegate int MyDelegate(string s);
    上面的委托可被用于引用任何一个带有一个单一的string参数的方法，并返回一个int类型变量
    声明委托的语法如下：
    delegate <return type> <delegate-name> <parameter list>
    实例化委托
    一旦声明委托类型，委托对象必须使用new关键字来创建
    public delegate void printString(string s);
    
    printString ps1 = new printString(writeToScreen);
    printString ps2 = new printString(writeToFile);
 */

 using System;
 delegate int NumberChange(int n);
 namespace DelegateApp
 {
     class TestDelegate
     {
         static int num = 10;
         public static int AddNum(int p)
         {
             num += p;
             return num;
         }

         public static int MultNum(int q)
         {
             num *= q;
             return num;
         }
         public static int getNum()
         {
             return num;
         }
         static void Main(string[] args)
         {
            //  创建委托实例
            NumberChange nc1 = new NumberChange(AddNum);
            NumberChange nc2 = new NumberChange(MultNum);
            // 使用委托对象调用方法
            nc1(25);
            System.Console.WriteLine("Values of Num:{0}",getNum());
            nc2(5);
            System.Console.WriteLine("Values of Num:{0}",getNum());
         }
     }
 }