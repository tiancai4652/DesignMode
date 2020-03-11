using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Facade : DesignModeBase
    {
        public Facade()
        {
            Name = "外观模式";
            Description = "外观模式提供了一个统一的接口，用来访问子系统中的一群接口。外观定义了一个高层接口，让子系统更容易使用。使用外观模式时，我们创建了一个统一的类，用来包装子系统中一个或多个复杂的类，客户端可以直接通过外观类来调用内部子系统中方法，从而外观模式让客户和子系统之间避免了紧耦合。";
            Why = "然而为了将复杂系统的内部子系统与客户端之间的依赖解耦，从而就有了外观模式，也称作 ”门面“模式";
          
            Advantage = new List<string>();
            Advantage.Add("外观模式对客户屏蔽了子系统组件，从而简化了接口，减少了客户处理的对象数目并使子系统的使用更加简单。");
            Advantage.Add("外观模式实现了子系统与客户之间的松耦合关系，而子系统内部的功能组件是紧耦合的。松耦合使得子系统的组件变化不会影响到它的客户");
            Weakness = new List<string>();
            Weakness.Add("如果增加新的子系统可能需要修改外观类或客户端的源代码");
           
            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "外观模式与适配器模式不同的是",
                Answer = "适配器模式是将一个对象包装起来以改变其接口，而外观是将一群对象 ”包装“起来以简化其接口。它们的意图是不一样的，适配器是将接口转换为不同接口，而外观模式是提供一个统一的接口来简化接口。"
            });

            implementation = "相当于一个外壳，外壳提供接口，外界的所有连接通过这个外壳接口去连接";
        }



    }
}
