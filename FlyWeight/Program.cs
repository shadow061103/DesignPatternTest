using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 20;
            FlyweightFactory f = new FlyweightFactory();
            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            Flyweight fy = f.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            Flyweight fz = f.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            Flyweight uf = new UnshareConcreteFlyweight();
            uf.Operation(--extrinsicstate);

            Console.ReadKey();

        }
    }
}
