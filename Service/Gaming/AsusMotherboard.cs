using Service.Contract;

namespace Service.Gaming
{
    public class AsusMotherboard : IMotherboard<IGaming>
    {
        public int NumberOfPciSlot => 4;
    }
}