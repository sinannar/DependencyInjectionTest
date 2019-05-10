using Service.Contract;

namespace Service.Budget
{
    public class AcerMotherboard : IMotherboard<IBudget>
    {
        public int NumberOfPciSlot => 1;
    }
}