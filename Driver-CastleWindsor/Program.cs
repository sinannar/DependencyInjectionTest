using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Service;
using Service.Budget;
using Service.Contract;
using Service.Gaming;

namespace Driver_CastleWindsor
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new WindsorContainer();

            container.Register(Component.For<IPrimaryMemory<IBudget>>().ImplementedBy<AliExpressMemory>());
            container.Register(Component.For<IMotherboard<IBudget>>().ImplementedBy<AcerMotherboard>());
            container.Register(Component.For<ISecondaryMemory<IBudget>>().ImplementedBy<AliBabaMemory>());
            container.Register(Component.For<IProcessor<IBudget>>().ImplementedBy<IntelI3>());
            container.Register(Component.For<IComputer<IBudget>>().ImplementedBy<Computer<IBudget>>());

            container.Register(Component.For<IPrimaryMemory<IGaming>>().ImplementedBy<KingstonMemory>());
            container.Register(Component.For<IMotherboard<IGaming>>().ImplementedBy<AsusMotherboard>());
            container.Register(Component.For<ISecondaryMemory<IGaming>>().ImplementedBy<Sandisk>());
            container.Register(Component.For<IProcessor<IGaming>>().ImplementedBy<IntelI7>());
            container.Register(Component.For<IComputer<IGaming>>().ImplementedBy<Computer<IGaming>>());

            var budgetComputer = container.Resolve<IComputer<IBudget>>();
            var gamingComputer = container.Resolve<IComputer<IGaming>>();

            budgetComputer.FunctionCallExample();
            gamingComputer.FunctionCallExample();
        }
    }
}
