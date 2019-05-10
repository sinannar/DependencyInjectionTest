using Service.Contract;

namespace Service.Budget
{
    public class IntelI3 : IProcessor<IBudget>
    {
        public int NumberOfCore => 2;

        public decimal CoreSpeed => (decimal)2.6;

        public string Model => "8300K";
    }
}