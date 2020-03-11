using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Composite : DesignModeBase
    {
        public Composite()
        {
            Name = "组合模式";
            Description = "为了使客户对简单对象和复杂对象的调用保持一致，我们使用组合模式来达到整个目的";
            Why = "组合模式允许你将对象组合成树形结构来表现”部分-整体“的层次结构，使得客户以一致的方式处理单个对象以及对象的组合";

            Advantage = new List<string>();
            Advantage.Add("组合模式使得客户端代码可以一致地处理对象和对象容器，无需关系处理的单个对象，还是组合的对象容器");
            Advantage.Add("可以更容易地往组合对象中加入新的构件");
            Weakness = new List<string>();
            Weakness.Add("使得设计更加复杂。客户端需要花更多时间理清类之间的层次关系");
           

            implementation = "简单对象和复杂对象共同继承一个base.....这样就可以实现对于一个base的共同调用了";
        }



    }
}
