using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class AbstractFactory: DesignModeBase
    {
        public AbstractFactory()
        {
            Name = "抽象工厂";
            Description = "一个工厂创建一系列的产品";
            Why = "允许客户使用抽象的接口来创建一组相关产品，而不需要知道或关心实际生产出的具体产品是什么";
            Advantage = new List<string>();
            Advantage.Add("抽象工厂模式将具体产品的创建延迟到具体工厂的子类中，这样将对象的创建封装起来，可以减少客户端与具体产品类之间的依赖，从而使系统耦合度低，这样更有利于后期的维护和扩展");
            Weakness = new List<string>();
            Weakness.Add("抽象工厂模式很难支持新种类产品的变化。这是因为抽象工厂接口中已经确定了可以被创建的产品集合，如果需要添加新产品，此时就必须去修改抽象工厂的接口，这样就涉及到抽象工厂类的以及所有子类的改变");
            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips()
            {
                Question = "抽象工厂方法和工厂方法模式有什么区别？",
                Answer = "区别在于产品，如果产品单一，最合适用工厂模式，但是如果有多个业务品种、业务分类时，通过抽象工厂模式产生需要的对象是一种非常好的解决方式。再通俗深化理解下：工厂模式针对的是一个产品等级结构，抽象工厂模式针对的是面向多个产品等级结构的。"
            });

            implementation = ".NET类库中也存在应用抽象工厂模式的类，这个类就是System.Data.Common.DbProviderFactory--SqlClientFactory ";
        }
    }
}
