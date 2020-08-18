using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Dynamics365.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Dynamics365.Unit.Test.Dynamics365Provider
{
    public abstract class Dynamics365ProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IDynamics365ClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected Dynamics365ProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IDynamics365ClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Dynamics365.Dynamics365Provider(applicationContext, NameClientFactory.Object);
        }
    }
}
