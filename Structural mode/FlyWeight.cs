using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FlyWeight : DesignModeBase
    {
        public FlyWeight()
        {
            Name = "享元模式";
            Description = "在软件开发过程，如果我们需要重复使用某个对象的时候，如果我们重复地使用new创建这个对象的话，这样我们在内存就需要多次地去申请内存空间了，这样可能会出现内存使用越来越多的情况，这样的问题是非常严重，然而享元模式可以解决这个问题";
            Why = "如果能把这些参数（指的这些类实例不同的参数）移动类实例外面，在方法调用时将他们传递进来，这样就可以通过共享大幅度地减少单个实例的数目：" +
                "比如说说围棋和跳棋，它们都有大量的棋子对象，围棋和五子棋只有黑白两色，跳棋颜色略多一点，但也是不太变化的，所以棋子颜色就是棋子的内部状态；而各个棋子之间的差别就是位置的不同，我们落子嘛，落子颜色是定的，但位置是变化的，所以方位坐标就是棋子的外部状态。";
            Advantage = new List<string>();
            Advantage.Add("降低了系统中对象的数量，从而降低了系统中细粒度对象给内存带来的压力。");

            Weakness = new List<string>();
            Weakness.Add("为了使对象可以共享，需要将一些状态外部化，这使得程序的逻辑更复杂，使系统复杂化");
          
            Tips = new List<Tips>();
            Tips.Add(new ClassLibrary1.Tips() {
                Question = "中心思想是啥",
                Answer = "把各对象放到了一个资源字典，通过字典来查找这些对象，没有再创建"
            });

            implementation = $"把不变的属性放到了一个资源字典，通过字典来查找这些属性，对象发现没有再创建在资源字典里创建这个属性" +
                $"说到享元模式，第一个想到的应该就是String常量池,比如我们每次创建字符串对象时，都需要创建一个新的字符串对象的话，内存开销会很大，所以如果第一次创建了字符串对象“adam“，下次再创建相同的字符串”adam“时，只是把它的引用指向”adam“，这样就实现了”adam“字符串再内存中的共享。";
        }



    }
}
