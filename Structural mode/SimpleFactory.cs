using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SimpleFactory: DesignModeBase
    {
        public SimpleFactory()
        {
            Name = "简单工厂";
            Description= "负责生产对象的一个类";
            Why = "由一个工厂类根据传入的参数决定创建出哪一种产品类的实例";
            Advantage = new List<string>();
            Advantage.Add($"1 解决了客户端直接依赖于具体对象的问题{Environment.NewLine}");
            Advantage.Add( $"2 简单工厂模式也起到了代码复用的作用，因为之前的实现（自己做饭的情况）中，换了一个人同样要去在自己的类中实现做菜的方法，然后有了简单工厂之后，去餐馆吃饭的所有人都不用那么麻烦了，只需要负责消费就可以了。此时简单工厂的烧菜方法就让所有客户共用了");
            Weakness = new List<string>();
            Weakness.Add("一旦添加新产品就不得不修改工厂逻辑，这样就会造成工厂逻辑过于复杂");

            implementation = "NET中System.Text.Encoding类就实现了简单工厂模式，该类中的GetEncoding(int codepage)就是工厂方法";
        }




    }
}
