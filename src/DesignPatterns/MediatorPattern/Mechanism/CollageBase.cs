namespace DesignPatterns.MediatorPattern.Mechanism
{
    public abstract class CollageBase
    {
        protected MediatorBase _mediator;

        public CollageBase(MediatorBase mediator)
        {
            _mediator = mediator;
        }
    }
}