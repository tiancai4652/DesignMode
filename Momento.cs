using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Momento : DesignModeBase
    {
        public Momento()
        {
            Name = "备忘录模式";
            Description = "在不破坏封装的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态，这样以后就可以把该对象恢复到原先的状态。";
            Why = "备忘录模式就是对某个类的状态进行保存下来，等到需要恢复的时候，可以从备忘录中进行恢复。生活中这样的例子经常看到，如备忘电话通讯录，备份操作操作系统，备份数据库等。";

            Advantage = new List<string>();
            Advantage.Add("如果某个操作错误地破坏了数据的完整性，此时可以使用备忘录模式将数据恢复成原来正确的数据。");
            Advantage.Add("备份的状态数据保存在发起人角色之外，这样发起人就不需要对各个备份的状态进行管理。而是由备忘录角色进行管理，而备忘录角色又是由管理者角色管理，符合单一职责原则。");

            Weakness = new List<string>();
            Weakness.Add("记得用深拷贝去拷贝数据并存储，如果是浅拷贝的话并且是引用类型的属性的话原来的删除了这个也删除了");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "备忘录模式适用场景",
                Answer = $"如果系统需要提供回滚操作时，使用备忘录模式非常合适。例如文本编辑器的Ctrl+Z撤销操作的实现，数据库中事务操作"
            });


            implementation = $"三个角色：一个备忘录发起者类，一个备忘录管理类，一个备忘录管理类{Environment.NewLine}" +
                $"发起者：记录当前时刻的内部状态，负责创建和恢复备忘录数据" +
                $"备忘录：负责存储发起人对象的内部状态，在进行恢复时提供给发起人需要的状态" +
                $"备忘录管理：负责保存备忘录对象，为保证多个还原点，备忘录应该是个字典";



        }



    }
}
