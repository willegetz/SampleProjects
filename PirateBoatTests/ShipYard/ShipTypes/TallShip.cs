namespace ShipYard
{
    public class TallShip
    {
        public TallShip()
        {
        }

        public string Name { get; internal set; }
        public string Masts { get; internal set; }
        public string Space { get; internal set; }

        public override string ToString()
        {
            return $"This is a {Masts} masted, {Name} ship with {Space} of cargo space.";
        }
    }
}