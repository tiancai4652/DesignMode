using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Observer : DesignModeBase
    {
        public Observer()
        {
            Name = "观察者模式";
            Description = "只要对订阅号进行关注的客户端，如果订阅号有什么更新，就会直接推送给订阅了的用户。";
            Why = "观察者模式定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象，这个主题对象在状态发生变化时，会通知所有观察者对象，使它们能够自动更新自己的行为。";


            Advantage = new List<string>();
            Advantage.Add("观察者模式实现了表示层和数据逻辑层的分离，并定义了稳定的更新消息传递机制，并抽象了更新接口，使得可以有各种各样不同的表示层，即观察者");
            Advantage.Add("观察者模式在被观察者和观察者之间建立了一个抽象的耦合，被观察者并不知道任何一个具体的观察者，只是保存着抽象观察者的列表，每个具体观察者都符合一个抽象观察者的接口");

            Weakness = new List<string>();
            Weakness.Add("如果在被观察者之间有循环依赖的话，被观察者会触发它们之间进行循环调用，导致系统崩溃，在使用观察者模式应特别注意这点");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "观察者模式适用场景",
                Answer = $"1 AOP" +
                $"{Environment.NewLine}" +
                $"当对一个对象的改变需要同时改变其他对象，而又不知道具体有多少对象,对象是谁的情况下"
            });


            implementation = $"1 内部管理一个订阅者列表，当触发消息时，foreach通知{Environment.NewLine}" +
                $"2 zai .NET中，适用委托使订阅者订阅事件来触发，if(NotifyEvent!=null)NotifyEvent(this)";
        }



    }
}
