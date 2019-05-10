namespace Service.Contract
{
    public interface IProcessor<T>
    {
        int NumberOfCore { get; }
        decimal CoreSpeed { get; }
        string Model { get; }
    }
}