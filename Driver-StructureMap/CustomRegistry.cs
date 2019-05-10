using System;
using StructureMap;
using Service;
using Service.Budget;
using Service.Contract;
using Service.Gaming;

namespace Driver_StructureMap
{
    class CustomRegistry : Registry
    {
        public CustomRegistry()
        {
            For<IPrimaryMemory<IBudget>>().Use<AliExpressMemory>();
            For<IPrimaryMemory<IGaming>>().Use<KingstonMemory>();

            For<IMotherboard<IBudget>>().Use<AcerMotherboard>();
            For<IMotherboard<IGaming>>().Use<AsusMotherboard>();

            For<ISecondaryMemory<IBudget>>().Use<AliBabaMemory>();
            For<ISecondaryMemory<IGaming>>().Use<Sandisk>();

            For<IProcessor<IBudget>>().Use<IntelI3>();
            For<IProcessor<IGaming>>().Use<IntelI7>();

            For<IComputer<IBudget>>().Use<Computer<IBudget>>();
            For<IComputer<IGaming>>().Use<Computer<IGaming>>();
            
        }
    }
}
