using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePatternDemo
{
    public class Program
    {
       public static void Main(string[] args)
        {
            //不合法的构造函数
            //会提示SingleObject具有一定的保护级别
            //SingleObject singleObject = new SingleObject();

            #region 单例模式实例01
            //通过getInstance方法获取唯一可用的对象
            SingleObject singleObject = SingleObject.GetInstance();
            #endregion

            //Singleton singleObject = Singleton.GetSingleton();
            Singleton singletonObject2 = Singleton.GetSingleton();

            singleObject.ShowMessage();
            if (singleObject.Equals(singletonObject2))
            {
                Console.WriteLine("singleObject 和 singletonObject2 是同一个对象");
            }
            else {
                Console.WriteLine("singleObject 和 singletonObject2 不是同一个对象");
            }

            Console.Read();
        }
    }
}
