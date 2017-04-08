using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOverrideCoverage
{
    public class A
    {
        public A()
        {

        }
        public void M1()
        {
            Console.WriteLine("待重载的方法");
        }
        /// <summary>
        /// M1的重载方法
        /// </summary>
        /// <param name="age"></param>
        public void M1(int age)
        {
            Console.WriteLine("重载的方法M1");
        }
        /// <summary>
        /// 虚方法
        /// </summary>
        public  virtual void M2()
        {
            Console.WriteLine("待重写的方法");
        }

        public void M3()
        {
            Console.WriteLine("待覆盖的方法");
        }
    }

    public class B : A
    {
        /// <summary>
        /// 重写基类的M2方法
        /// </summary>
        public override void M2()
        {
            //base.M2();
        }
        /// <summary>
        ///覆盖基类的M3方法,不影响基类M3方法
        /// </summary>
        public new void M3()
        {
            Console.WriteLine("子类覆盖后的M3方法");
        }
    }

    public class C
    {
        static void Main(string[] args)
        {
            var a = new A();
            a.M3();
            var b = new B();
            b.M3();

            A a1 = new B();
            a1.M3();
        }
    }
}
