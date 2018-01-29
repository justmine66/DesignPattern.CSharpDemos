namespace DesignPatterns.VisitorPattern.Mechanism
{
    public class ConcreteElementA: AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }
    }
}