using System;
using Ninject;
using Service;
using Service.Contract;

namespace Driver_Ninject
{
    class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel(new BudgetModule(), new GamingModule());  

            var budgetComputer = kernel.Get<IComputer<IBudget>>();
            var gamingComputer = kernel.Get<IComputer<IGaming>>();

            budgetComputer.FunctionCallExample();
            gamingComputer.FunctionCallExample();
        }
    }
}
