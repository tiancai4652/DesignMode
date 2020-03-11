using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mediator : DesignModeBase
    {
        public Mediator()
        {
            Name = "中介  者模式";
            Description = "定义了一个中介对象来封装一系列对象之间的交互关系。中介者使各个对象之间不需要显式地相互引用，从而使耦合性降低，而且可以独立地改变它们之间的交互行为。";
            Why = "不论是QQ游戏还是QQ群，它们都是充当一个中间平台，QQ用户可以登录这个中间平台与其他QQ用户进行交流，如果没有这些中间平台，我们如果想与朋友进行聊天的话，可能就需要当面才可以了。电话、短信也同样是一个中间平台，有了这个中间平台，每个用户都不要直接依赖与其他用户，只需要依赖这个中间平台就可以了，一切操作都由中间平台去分发。使用中介者模式之后，任何一个类的变化，只会影响中介者和类本身，不像之前的设计，任何一个类的变化都会引起其关联所有类的变化。这样的设计大大减少了系统的耦合度";

            Advantage = new List<string>();
            Advantage.Add("将各个同事类解耦，使得系统变为松耦合");

            Weakness = new List<string>();
            Weakness.Add("中介者模式中，中介者角色承担了较多的责任，所以一旦这个中介者对象出现了问题，整个系统将会受到重大的影响");
            Weakness.Add("新增加一个同事类时，不得不去修改抽象中介者类和具体中介者类，此时可以使用观察者模式和状态模式来解决这个问题。");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "中介者模式适用场景",
                Answer = $"1 一组定义良好的对象，现在要进行复杂的相互通信" +
                $"{Environment.NewLine}" +
                $"想通过一个中间类来封装多个类中的行为，而又不想生成太多的子类"
            });


            implementation = "首先有很多个需要交互的实例，然后定义一个中介者类将这些实例传进去，每个实例变化时，调用中介者去变化";
        }



    }
}
