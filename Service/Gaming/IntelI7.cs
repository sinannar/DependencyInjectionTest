using Service.Contract;

namespace Service.Gaming
{
    public class IntelI7 : IProcessor<IGaming>
    {
        public int NumberOfCore => 6;

        public decimal CoreSpeed => (decimal)3.6;

        public string Model => "8700K";
    }
}