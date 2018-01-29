namespace DesignPatterns.VisitorPattern.v2
{
    public class Man : AbstractPerson
    {
        public override void Accept(AbstractAction visitor)
        {
            visitor.GetManConclusion(this);
        }
    }
}