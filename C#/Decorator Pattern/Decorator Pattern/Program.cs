using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ab = new Person("ab");
            Console.Write("1\n");
            KK kk = new KK();
            TShirts ts = new TShirts();
            kk.Decorate(ab);
            ts.Decorate(kk);
            ts.Show();
            Console.Read();

        }
    }
    class Person
    {
        public Person() { }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",name);
        }
    }
    class Finery : Person
    {
        protected Person component;
        //打扮
        public void Decorate(Person component)
        {
            this.component = component;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }
        }
    }
    class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤");
            base.Show();
        }
    }
    class KK : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤");
            base.Show();
        }
    }
   /* abstract class Component
    {
        public abstract void Operation();
    }
    class ConreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("具体对象的操作");
        }
    }
    abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component component)
        {
            this.component = component;
        }
        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }
    class ComcreteDecoratorA : Decorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具体装饰对象A的操作");
        }
    }
    class ComcreteDecoratorB : Decorator
    {
        
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("具体装饰对象B的操作");
        }
    }*/
}
