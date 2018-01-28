namespace DesignPatterns.MediatorPattern.v1
{
    public abstract class Country
    {
        protected UnitedNations _unitedNations;
        public Country(UnitedNations unitedNations)
        {
            _unitedNations = unitedNations;
        }
    }
}