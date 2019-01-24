/*
    事件在类中声明且生成，且通过使用同一个类或其他类中的委托与事件处理程序关联
    包含事件的类用于发布事件，这被称为发布器，其他接收该事件的类被称为订阅器
    发布器是一个包含事件和委托定义的对象，事件和委托之间的联系也定义在这个对象中，
    发布器类的对象调用这个事件，并通过调用这个事件，并通知其他的对象
    订阅器是一个接受事件并提供事件处理程序的对象，在发布器类中的委托调用订阅器类中的方法（事件处理程序）

    声明一个委托，实际上就相当于创建一个命令，首先必须声明该事件的委托类型
    public delegate void BoilerLogHandler(string status);
    声明事件本身，使用event关键字
    public event BoilerLogHandler BoilerEventLog;
    事件在生成的时候会调用委托
 */
 using System;
 namespace SimpleEvent
 {
     using System;
     /***发布器类***/
     public class EventTest
     {
         private int value;

         public delegate void NumManipulationHandler();

         public event NumManipulationHandler changeNum;

         protected virtual void OnNumChanged()
         {
             if(changeNum != null)
             {
                 changeNum();//事件被触发
             }else{
                 System.Console.WriteLine("event not fire");
             }
         }

         public EventTest()
         {
             int n = 5;
             setValue(n);
         }
         public void setValue(int n)
         {
             if(value!= n)
             {
                 value = n;
                 OnNumChanged();
             }
         }
     }

     /*订阅器类*/
     public class subscribEvent
     {
         public void printf()
         {
             System.Console.WriteLine("event fire");
         }
     }
     /*触发类*/
     public class MainClass
     {
         static void Main(string[] args)
         {
             EventTest e = new EventTest();/*实例化对象，第一次没有触发事件 */
             subscribEvent v = new subscribEvent();/*实例化对象 */
             e.changeNum += new EventTest.NumManipulationHandler(v.printf);/*注册 */
             e.setValue(7);
             e.setValue(11);
         }
     }
 }