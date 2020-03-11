using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Command : DesignModeBase
    {
        public Command()
        {
            Name = "命令模式";
            Description = "命令模式是把一个操作或者行为抽象为一个对象中，通过对命令的抽象化来使得发出命令的责任和执行命令的责任分隔开。命令模式的实现可以提供命令的撤销和恢复功能。";
            Why = "命令模式是实现把发出命令的责任和执行命令的责任分割开，然而中间必须有某个对象来帮助发出命令者来传达命令，使得执行命令的接收者可以收到命令并执行命令";


            Advantage = new List<string>();
            Advantage.Add("可以设计一个命令队列来实现对请求的Undo和Redo操作");
            Advantage.Add("命令模式使得命令发出的一个和接收的一方实现低耦合");

            Weakness = new List<string>();
            Weakness.Add("使用命令模式可能会导致系统有过多的具体命令类。这会使得命令模式在这样的系统里变得不实际");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "什么情况考虑适用命令模式",
                Answer = "系统需要支持命令的撤销（undo）。命令对象可以把状态存储起来，等到客户端需要撤销命令所产生的效果时，可以调用undo方法吧命令所产生的效果撤销掉。命令对象还可以提供redo方法，以供客户端在需要时，再重新实现命令效果。" +
                "原来请求的发出者可能已经不存在了，而命令对象本身可能仍是活动的" +
                ""
            });


            implementation = "军训场景中，具体的命令即是学生跑1000米，这里学生是命令的接收者，教官是命令的转发者，院领导是命令的发出者：" +
                "教官发送命令时得知道命令内容，教官和学生对象，即客户端的执行命令时需要获取命令本身，命令转发者，命令接受者实例" +
                "命令包含学生实例，即命令包含接收者实例" +
                "教官包含命令实例，即转发者包含命令实例";
        }



    }
}
