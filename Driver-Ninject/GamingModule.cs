using System;
using Ninject;
using Ninject.Modules;
using Service;
using Service.Budget;
using Service.Contract;
using Service.Gaming;

namespace Driver_Ninject
{
    public class GamingModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrimaryMemory<IGaming>>().To<KingstonMemory>();
            Bind<IMotherboard<IGaming>>().To<AsusMotherboard>();
            Bind<ISecondaryMemory<IGaming>>().To<Sandisk>();
            Bind<IProcessor<IGaming>>().To<IntelI7>();
            Bind<IComputer<IGaming>>().To<Computer<IGaming>>();
        }
    }
}
