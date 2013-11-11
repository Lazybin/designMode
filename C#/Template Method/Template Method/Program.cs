using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPaperA studentA = new TestPaperA();
            studentA.QustionA();
            studentA.QustionB();

            TestPaperB studentB = new TestPaperB();
            studentB.QustionA();
            studentB.QustionB();
            Console.Read();
        }
       
    }
    class TestPaper
    {
        public void QustionA()
        {
            Console.Write("蝙蝠骑士的不稳定化合物（即自爆）威力无比。如果该化合物（混合物）是简单的无机物、能随时使用，且不是黑****等，那么它最有可能是下列哪种：（ ）\n A、X钾 B、高氟酸 C、氢气+氧气 D、氢气+氟气");
            Console.WriteLine("\n答案："+Answer1());
        }
        public void QustionB()
        {
            Console.Write("化学成分分析表明，石像鬼硬化过程中并没有改变体内各元素的含量，那么石像鬼硬化最可能是下列哪种元素组成的物质发生异构？（ ）\nA、铁 B、硅 C、碳 D、钙");
            Console.WriteLine("\n答案：" + Answer2());
        }
        public virtual string Answer1()
        {
            return "";
        }
        public virtual string Answer2()
        {
            return "";
        }
    }
    class TestPaperA : TestPaper
    {
        public override string Answer1()
        {
            return "d";
        }
        public override string Answer2()
        {
            return "a";
        }
    }
    class TestPaperB : TestPaper
    {
        public override string Answer1()
        {
            return "b";
        }
        public override string Answer2()
        {
            return "c";
        }
    }
}
