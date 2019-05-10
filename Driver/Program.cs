using System;
using Microsoft.Extensions.DependencyInjection;
using Service.Contract;
using Service;
using Service.Gaming;
using Service.Budget;

namespace Driver
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()

                .AddScoped(typeof(IPrimaryMemory<IBudget>), typeof(AliExpressMemory))
                .AddScoped(typeof(IPrimaryMemory<IGaming>), typeof(KingstonMemory))
                
                .AddScoped(typeof(IMotherboard<IBudget>), typeof(AcerMotherboard))
                .AddScoped(typeof(IMotherboard<IGaming>), typeof(AsusMotherboard))
                
                .AddScoped(typeof(ISecondaryMemory<IBudget>), typeof(AliBabaMemory))
                .AddScoped(typeof(ISecondaryMemory<IGaming>), typeof(Sandisk))
                
                .AddScoped(typeof(IProcessor<IBudget>), typeof(IntelI3))
                .AddScoped(typeof(IProcessor<IGaming>), typeof(IntelI7))
                
                .AddScoped(typeof(IComputer<IBudget>), typeof(Computer<IBudget>))
                .AddScoped(typeof(IComputer<IGaming>), typeof(Computer<IGaming>))
                
                .BuildServiceProvider();

            var budgetComputer = serviceProvider.GetService<IComputer<IBudget>>();
            var gamingComputer = serviceProvider.GetService<IComputer<IGaming>>();

            budgetComputer.FunctionCallExample();
            gamingComputer.FunctionCallExample();
        }
    }
}
