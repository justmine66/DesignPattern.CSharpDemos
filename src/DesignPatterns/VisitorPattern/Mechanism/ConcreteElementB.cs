namespace DesignPatterns.VisitorPattern.Mechanism
{
    public class ConcreteElementB : AbstractElement
    {
        public override void Accept(AbstractVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }
    }
}