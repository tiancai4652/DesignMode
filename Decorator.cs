using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Decorator : DesignModeBase
    {
        public Decorator()
        {
            Name = "装饰者";
            Description = "我们经常想要对一类对象添加不同的功能，例如要给手机添加贴膜，手机挂件，手机外壳等，我们可以使用装饰者模式来动态地给一个对象添加额外的职责";
            Why = "装饰者模式以对客户透明的方式动态地给一个对象附加上更多的责任，装饰者模式相比生成子类可以更灵活地增加功能。";

            Advantage = new List<string>();
            Advantage.Add("都是扩展对象的功能，但装饰者模式比继承更灵活");

            Weakness = new List<string>();
            Weakness.Add("装饰者模式会导致设计中出现许多小对象，如果过度使用，会让程序变的更复杂。并且更多的对象会是的差错变得困难，特别是这些对象看上去都很像");



            implementation = "装饰者类与原类继承同一个接口，装饰者类的构造函数把原类传进去，扩展他的方法，外面用的时候还是base=子类";
        }



    }
}
