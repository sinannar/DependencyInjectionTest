using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Contract
{
    public interface IMotherboard<T>
    {
        int NumberOfPciSlot { get; }
    }
}
