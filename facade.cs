using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class facade : DesignModeBase
    {
        public facade()
        {
            Name = "一般工厂";
            Description = "负责生产对象的一个类";
            Why = "由一个工厂类根据传入的参数决定创建出哪一种产品类的实例";
            Advantage = new List<string>();
            Advantage.Add("作为一种创建类模式，在任何需要生成复杂对象的地方，都可以使用工厂方法模式");
            Advantage.Add("使用工厂模式。将会大大降低对象之间的耦合度");
            Advantage.Add("它把实例化产品的任务交由实现类完成，扩展性比较好");
            Weakness = new List<string>();
            Weakness.Add("客户端调用时必须先创建某具体工厂，再创建实例，感觉和直接new一个差不多");
            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "我为什么要这么麻烦先创建一个工厂再创建产品对象呢？我直接new一个对象出来不挺好的吗",
                Answer = "1 主要解决框架或者sdk不想暴露给客户端具体的实例的创建过程" + Environment.NewLine
                + "当需要改成单例模式或者其他实例化方式的时候就需要改动所有实例化的地方，而使用工厂模式只需要改动相应的工厂一个地方，客户端并不需要任何改动。"
            });

            implementation = "基类 a=子类a，基类.Creat=实体类.Creat 返回值为food基类（实际为实体类的实物）";
        }



    }
}
