using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Iterator : DesignModeBase
    {
        public Iterator()
        {
            Name = "迭代器模式";
            Description = "　迭代器是针对集合对象而生的，对于集合对象而言，必然涉及到集合元素的添加删除操作，同时也肯定支持遍历集合元素的操作，我们此时可以把遍历操作也放在集合对象中，但这样的话，集合对象就承担太多的责任了，面向对象设计原则中有一条是单一职责原则，所以我们要尽可能地分离这些职责，用不同的类去承担不同的职责。迭代器模式就是用迭代器类来承担遍历集合元素的职责。";
            Why = "迭代器模式提供了一种方法顺序访问一个聚合对象（理解为集合对象）中各个元素，而又无需暴露该对象的内部表示，这样既可以做到不暴露集合的内部结构，又可让外部代码透明地访问集合内部的数据";


            Advantage = new List<string>();
            Advantage.Add("迭代器模式使得访问一个聚合对象的内容而无需暴露它的内部表示，即迭代抽象");
            Advantage.Add("迭代器模式为遍历不同的集合结构提供了一个统一的接口，从而支持同样的算法在不同的集合结构上进行操作");

            Weakness = new List<string>();
            Weakness.Add("迭代器模式在遍历的同时更改迭代器所在的集合结构会导致出现异常。所以使用foreach语句只能在对集合进行遍历，不能在遍历的同时更改集合中的元素。");


            implementation = "在.NET下，迭代器模式中的聚集接口和迭代器接口都已经存在了，其中IEnumerator接口扮演的就是迭代器角色，IEnumberable接口则扮演的就是抽象聚集的角色";
        }



    }
}
