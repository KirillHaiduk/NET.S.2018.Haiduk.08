using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2018.Haiduk._08.Account_Service;
using NET.S._2018.Haiduk._08.RepositoryService;
using Ninject;
using Ninject.Activation;
using Ninject.Modules;

namespace NET.S._2018.Haiduk._08.Infrastructure
{
    class NinjectDependencyResolver : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository>().To<ListRepository>();
            Bind<IBonusCalculator>().To<StandartBonusCalculator>();
        }        
    }
}
