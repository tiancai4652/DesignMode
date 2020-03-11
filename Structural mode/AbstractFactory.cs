using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bridge : DesignModeBase
    {
        public Bridge()
        {
            Name = "桥接模式";
            Description = "桥接模式即将抽象部分与实现部分脱耦，使它们可以独立变化。";
            Why = "即抽象类方法的实现分为两部分，一部分是抽象类子类的实现，一部分是抽象类属性的实现，==>method:property.dosomething,这样如果想";
            
            Advantage = new List<string>();
            Advantage.Add("抽象和实现可以独立扩展，不会影响到对方");
            Advantage.Add("如果一个系统需要在构件的抽象化角色和具体化角色之间添加更多的灵活性，避免在两个层次之间建立静态的联系");
            Advantage.Add("如果遥控器有A种，电视B种 继承实现 需要 A*B个类。桥接实现 就是A + B个类");

           
         

            implementation = "三层架构中的业务逻辑层BLL中通过桥接模式与数据操作层解耦（DAL），其实现方式就是在BLL层中引用了DAL层中一个引用。这样数据操作的实现可以在不改变客户端代码的情况下动态进行更换";
        }
    }
}
