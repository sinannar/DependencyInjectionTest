using System;
using Ninject;
using Ninject.Modules;
using Service;
using Service.Budget;
using Service.Contract;
using Service.Gaming;

namespace Driver_Ninject
{
    public class BudgetModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPrimaryMemory<IBudget>>().To<AliExpressMemory>();
            Bind<IMotherboard<IBudget>>().To<AcerMotherboard>();
            Bind<ISecondaryMemory<IBudget>>().To<AliBabaMemory>();
            Bind<IProcessor<IBudget>>().To<IntelI3>();
            Bind<IComputer<IBudget>>().To<Computer<IBudget>>();
        }
    }
}
