using Service.Contract;

namespace Service.Gaming
{
    public class KingstonMemory : IPrimaryMemory<IGaming>
    {
        public int SpaceInGb => 4;
    }
}