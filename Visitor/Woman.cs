using System;

namespace Visitor
{
    class Woman : Person
    {
        public override void Accept(Action visitor)
        {
            visitor.GetWoManConclusion(this);
        }
    }
}