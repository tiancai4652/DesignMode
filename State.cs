using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class State : DesignModeBase
    {
        public State()
        {
            Name = "状态者模式";
            Description = "允许一个对象在其内部状态改变时自动改变其行为，对象看起来就像是改变了它的类。";
            Why = "　每个对象都有其对应的状态，而每个状态又对应一些相应的行为，如果某个对象有多个状态时，那么就会对应很多的行为。那么对这些状态的判断和根据状态完成的行为，就会导致多重条件语句，并且如果添加一种新的状态时，需要更改之前现有的代码。这样的设计显然违背了开闭原则。状态模式正是用来解决这样的问题的。状态模式将每种状态对应的行为抽象出来成为单独新的对象，这样状态的变化不再依赖于对象内部的行为。";

            Advantage = new List<string>();
            Advantage.Add("将状态判断逻辑每个状态类里面，可以简化判断的逻辑");
            Advantage.Add("当有新的状态出现时，可以通过添加新的状态类来进行扩展，扩展性好");

            Weakness = new List<string>();
            Weakness.Add("如果状态过多的话，会导致有非常多的状态类，加大了开销");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "状态者模式适用场景",
                Answer = $"1 当一个对象行为取决于它的状态，并且它需要在运行时刻根据状态改变它的行为时，就可以考虑使用状态者模式" +
                $"{Environment.NewLine}" +
                $"当一个对象状态转换的条件表达式过于复杂时可以使用状态者模式。把状态的判断逻辑转移到表示不同状态的一系列类中，可以把复杂的判断逻辑简单化。"
            });


            implementation = "主体类里面有个状态者基类实例，行为是state实例去执行的，有一个StateChanged的方法，当触发方法的时，触发StateChanged方法，状态者基类实例会改变";
        }



    }
}
