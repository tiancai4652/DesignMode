using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ChainofResponsibility : DesignModeBase
    {
        public ChainofResponsibility()
        {
            Name = "责任链模式";
            Description = "在现实生活中，有很多请求并不是一个人说了就算的，例如面试时的工资，低于1万的薪水可能技术经理就可以决定了，但是1万~1万5的薪水可能技术经理就没这个权利批准，可能就需要请求技术总监的批准，所以在面试的完后，经常会有面试官说，你这个薪水我这边觉得你这技术可以拿这个薪水的，但是还需要技术总监的批准等的话。";
            Why = "某个请求需要多个对象进行处理，从而避免请求的发送者和接收之间的耦合关系。将这些对象连成一条链子，并沿着这条链子传递该请求，直到有对象处理它为止。";

            Advantage = new List<string>();
            Advantage.Add("降低了请求的发送者和接收者之间的耦合。");
            Advantage.Add("把多个条件判定分散到各个处理类中，使得代码更加清晰，责任更加明确。");

            Weakness = new List<string>();
            Weakness.Add("在找到正确的处理对象之前，所有的条件判定都要执行一遍，当责任链过长时，可能会引起性能的问题（个人感觉也不能直观的看条件）");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "责任链模式适用场景",
                Answer = $"1 一个系统的审批需要多个对象才能完成处理的情况下，例如请假系统等" +
                $"{Environment.NewLine}" +
                $"代码中存在多个if-else语句的情况下，此时可以考虑使用责任链模式来对代码进行重构"
            });


            implementation = $"组长，经理，副总责任链，实例化的时候将组长，经理，副总实例化，然后组长.NextChain=经理,经理.NextChain=副总{Environment.NewLine}" +
                $"执行组长.Handle方法，如果符合条件触发组长.NextChain.Hnadle也就是经理.NextChain.Hnadle，如果符合条件，触发组长.NextChain.NextChain也就是副总.Handle";
        }



    }
}
