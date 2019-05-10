using System;
using StructureMap;
using Service;
using Service.Budget;
using Service.Contract;
using Service.Gaming;

namespace Driver_StructureMap
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new Container(c => c.AddRegistry<CustomRegistry>());
            
            var budgetComputer = container.GetInstance<IComputer<IBudget>>();
            var gamingComputer = container.GetInstance<IComputer<IGaming>>();

            budgetComputer.FunctionCallExample();
            gamingComputer.FunctionCallExample();
        }
    }
}
