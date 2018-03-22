using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* http://www.dotnettricks.com/learn/designpatterns/strategy-design-pattern-c-sharp
 * Topic Strategy Design pattern:
This pattern involves the removal of an algorithm from its host class and putting it in a separate class. 
 * As you know, there may be multiple strategies which are applicable for a given problem.
 * So, if the algorithms will exist in the host class, then it will result a messy code with lots of
 * conditional statements

Context
This is a class that contains a property to hold the reference of a Strategy object. This property will be set at run-time according to the algorithm that is required.

Strategy
This is an interface that is used by the Context object to call the algorithm defined by a ConcreteStrategy.

ConcreteStrategyA/B
These are classes that implements Strategy interface.
*/
namespace DesignPatterns
{
    class StrategyDesign
    {
        static void Method(string[] args)
        {
            Client objA = new Client();
            objA.Strategy = new ConcreteStrategyBus();
            objA.CallAlgorithm();
            Console.WriteLine();

            Client objB = new Client();
            objB.Strategy = new ConcreteStrategyWalk();
            objB.CallAlgorithm();
        }
    }

    public class Client
    {
        //This pattern involves the removal of an algorithm from its host class
        //and putting it in a separate class which implements IStrategy interface.
        public IStrategy Strategy { get; set; }

        public void CallAlgorithm()
        {
            Console.WriteLine(Strategy.Algorithm());
        }
    }

    public interface IStrategy
    {
        string Algorithm();
    }

    public class ConcreteStrategyBus : IStrategy
    {
        public string Algorithm()
        {
            return "Going by Bus Strategy";
        }
    }

    public class ConcreteStrategyWalk : IStrategy
    {
        public string Algorithm()
        {
            return "--Going by Walk-Walk Strategy--";
        }
    }
}