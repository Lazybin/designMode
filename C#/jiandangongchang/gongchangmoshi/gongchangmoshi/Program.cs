using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gongchangmoshi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入数字A：");
            string numberA = Console.ReadLine();
            Console.Write("请输入运算符：");
            string operation = Console.ReadLine();
            Console.Write("请输入数字B：");
            string numberB = Console.ReadLine();
            string numberD = "";
            Operation oper = OperationFactory.createOperation(operation);
            oper.NumberA = Convert.ToDouble(numberA);
            oper.NumberB = Convert.ToDouble(numberB);
            string result = Convert.ToString(oper.GetResult());
            Console.WriteLine("结果是："+result);
            return ;

        }
    }
    class OperationFactory
    {
        public static Operation createOperation(string operation)
        {
            Operation oper;
            switch (operation)
            {
                case "+":
                    oper= new operationAdd();
                    break;
                case "-":
                    oper = new operationSub();
                    break;
                case "*":
                    oper = new operationCheng();
                    break;
                default:
                    oper = null;
                    break;
                   
            }
            return oper;
        }
    }

    class Operation
    {
        private double numberA = 0;
        private double numberB = 0;
        public double NumberA 
        {
            get { return numberA; }
            set { numberA =value; }
        }
        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    class operationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
    class operationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    class operationCheng : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
}
