using Service.Contract;

namespace Service.Budget
{
    public class AliExpressMemory : IPrimaryMemory<IBudget>
    {
        public int SpaceInGb => 4;
    }
}