using Autofac;
using Service;
using Service.Budget;
using Service.Contract;
using Service.Gaming;
using System;

namespace Driver_Autofact
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AliExpressMemory>().As<IPrimaryMemory<IBudget>>();
            builder.RegisterType<KingstonMemory>().As<IPrimaryMemory<IGaming>>();

            builder.RegisterType<AcerMotherboard>().As<IMotherboard<IBudget>>();
            builder.RegisterType<AsusMotherboard>().As<IMotherboard<IGaming>>();

            builder.RegisterType<AliBabaMemory>().As<ISecondaryMemory<IBudget>>();
            builder.RegisterType<Sandisk>().As<ISecondaryMemory<IGaming>>();

            builder.RegisterType<IntelI3>().As<IProcessor<IBudget>>();
            builder.RegisterType<IntelI7>().As<IProcessor<IGaming>>();

            builder.RegisterType<Computer<IBudget>>().As<IComputer<IBudget>>();
            builder.RegisterType<Computer<IGaming>>().As<IComputer<IGaming>>();


            var conter = builder.Build();

            var budgetComputer = conter.Resolve<IComputer<IBudget>>();
            var gamingComputer = conter.Resolve<IComputer<IGaming>>();

            budgetComputer.FunctionCallExample();
            gamingComputer.FunctionCallExample();
        }
    }
}
