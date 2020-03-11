using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Vistor : DesignModeBase
    {
        public Vistor()
        {
            Name = "访问者模式";
            Description = "能不能把操作于元素的操作和元素本身的数据结构分开呢？解开这两者的耦合度，这样如果是操作发现变化时，就不需要去更改元素本身了。";
            Why = "　能不能把操作于元素的操作和元素本身的数据结构分开呢？解开这两者的耦合度，这样如果是操作发现变化时，就不需要去更改元素本身了";

            Advantage = new List<string>();
            Advantage.Add("访问者模式使得添加新的操作变得容易");
            Advantage.Add("访问者模式使得有关的行为操作集中到一个访问者对象中，而不是分散到一个个的元素类中。这点类似与中介者模式");

            Weakness = new List<string>();
            Weakness.Add("增加新的元素类变得困难。每增加一个新的元素意味着要在抽象访问者角色中增加一个新的抽象操作，并在每一个具体访问者类中添加相应的具体操作");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "访问者模式适用场景",
                Answer = $"1 如果系统有比较稳定的数据结构，而又有易于变化的算法时，此时可以考虑使用访问者模式。因为访问者模式使得算法操作的添加比较容易" +
                $"{Environment.NewLine}" +
                $"2 如果一组类中，存在着相似的操作，为了避免出现大量重复的代码，可以考虑把重复的操作封装到访问者中。（当然也可以考虑使用抽象类了）" +
                $"{Environment.NewLine}" +
                $"3 如果一个对象存在着一些与本身对象不相干，或关系比较弱的操作时，为了避免操作污染这个对象，则可以考虑把这些操作封装到访问者对象中"
            });


            implementation = "把数据类里面的方法提出来，将方法替换成类.方法，那么当方法有什么变动，只需要更改这个类.方法就行了而不用改写每一个功能类";
        }



    }
}
