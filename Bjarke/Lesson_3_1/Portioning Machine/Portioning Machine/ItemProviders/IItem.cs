namespace Portioning_Machine.ItemProviders
{
    public interface IItem
    {
        uint Id { get; }
        double Weight { get; }
    }
}