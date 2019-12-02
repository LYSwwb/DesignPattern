using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePatternDemo
{
    public class SingleObject
    {
        //创建 SingleObject 的一个静态对象
        private static SingleObject instance = new SingleObject();

        //让构造函数为private,这样该类就不会被实例化
        private SingleObject() { }

        //获取唯一可用的对象
        public static SingleObject GetInstance() {
            return instance;
        }

        public void ShowMessage() {
            Console.WriteLine("单例测试");
        }
    }
}
