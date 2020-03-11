using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Strategy : DesignModeBase
    {
        public Strategy()
        {
            Name = "策略者模式";
            Description = "策略的意思就是方法，所以也就是对方法的抽象。将每个算法封装到不同的策略类中，使得它们可以互换";
            Why = "中国的所得税，分为企业所得税、外商投资企业或外商企业所得税和个人所得税，针对于这3种所得税，针对每种，所计算的方式不同，" +
                "个人所得税有个人所得税的计算方式，而企业所得税有其对应计算方式。如果不采用策略模式来实现这样一个需求的话，可能我们会定义一个所得税类，" +
                "该类有一个属性来标识所得税的类型，并且有一个计算税收的CalculateTax()方法，在该方法体内需要对税收类型进行判断，" +
                "通过if-else语句来针对不同的税收类型来计算其所得税。这样的实现确实可以解决这个场景吗，但是这样的设计不利于扩展，" +
                "如果系统后期需要增加一种所得税时，此时不得不回去修改CalculateTax方法来多添加一个判断语句，这样明白违背了“开放——封闭”原则";

            Advantage = new List<string>();
            Advantage.Add("策略类之间可以自由切换。由于策略类都实现同一个接口，所以使它们之间可以自由切换。");
            Advantage.Add("易于扩展。增加一个新的策略只需要添加一个具体的策略类即可，基本不需要改变原有的代码。");
            Advantage.Add("避免使用多重条件选择语句，充分体现面向对象设计思想。");

            Weakness = new List<string>();
            Weakness.Add("客户端必须知道所有的策略类，并自行决定使用哪一个策略类。这点可以考虑使用IOC容器和依赖注入的方式来解决");

            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "状态者模式适用场景",
                Answer = $"1 当一个对象行为取决于它的状态，并且它需要在运行时刻根据状态改变它的行为时，就可以考虑使用状态者模式" +
                $"{Environment.NewLine}" +
                $"当一个对象状态转换的条件表达式过于复杂时可以使用状态者模式。把状态的判断逻辑转移到表示不同状态的一系列类中，可以把复杂的判断逻辑简单化。"
            });


            implementation = $"1 把变化的方法抽出来放在类里，然后用基类去替换这个方法，使用这个方法的时候用基类.方法调用，当然实例化的时候是把真实的方法类传进来的{Environment.NewLine}" +
                $"2 在.NET中，为集合类型ArrayList和List<T>提供的排序功能，其中实现就利用了策略模式，定义了IComparer接口来对比较算法进行封装，实现IComparer接口的类可以是顺序，或逆序地比较两个对象的大小，具体.NET中的实现可以使用反编译工具查看List<T>.Sort(IComparer<T>)的实现。其中List<T>就是承担着环境角色，而IComparer<T>接口承担着抽象策略角色，具体的策略角色就是实现了IComparer<T>接口的类，List<T>类本身实现了存在实现了该接口的类，我们可以自定义继承与该接口的具体策略类。";
        }



    }
}
