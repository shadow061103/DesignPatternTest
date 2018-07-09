using System;

namespace Visitor
{
     class Man : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}