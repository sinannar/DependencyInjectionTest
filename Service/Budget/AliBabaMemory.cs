using Service.Contract;

namespace Service.Gaming
{
    public class AliBabaMemory : ISecondaryMemory<IBudget>
    {
        public int SpaceInGb => 120;
    }
}