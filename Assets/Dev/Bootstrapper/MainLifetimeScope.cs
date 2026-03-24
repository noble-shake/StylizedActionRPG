using System;
using System.Resources;
using VContainer;
using VContainer.Unity;

namespace Extention.Vcontainer
{
    public class MainLifetimeScope : LifetimeScope
    {
        

        protected override void Configure(IContainerBuilder builder)
        {
            builder.Register<ResourceManager>(Lifetime.Singleton).AsImplementedInterfaces().AsSelf();    
        }
    }

}

