namespace DesignPatterns.VisitorPattern.v2
{
    public class Woman : AbstractPerson
    {
        public override void Accept(AbstractAction visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
}