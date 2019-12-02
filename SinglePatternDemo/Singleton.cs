using System;
using System.Threading;

namespace SinglePatternDemo
{
    public class Singleton
    {
        private static Singleton instance;
        private Singleton() { }

        #region 懒汉式 线程不安全
        public static Singleton GetSingleton()
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }
        #endregion




        public void ShowMessage() {
            Console.WriteLine("单例模式  懒汉式，线程不安全");
        }
    }
}
