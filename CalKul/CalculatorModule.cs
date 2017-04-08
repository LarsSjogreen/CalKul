using System;
using Ninject;
using Ninject.Modules;

namespace CalKul
{
    internal class CalculatorModule : NinjectModule
    {
        public CalculatorModule()
        {
        }

        public override void Load()
        {
            Bind<IUserInterface>().To<ConsoleUserInterface>();
            Bind<IVariableStorage>().To<InMemoryVariableStorage>();
            Bind<IConfigurator>().To<InMemoryConfigurator>();
        }
    }
}