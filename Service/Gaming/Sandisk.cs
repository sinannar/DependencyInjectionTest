using Service.Contract;

namespace Service.Gaming
{
    public class Sandisk : ISecondaryMemory<IGaming>
    {
        public int SpaceInGb => 500;
    }
}