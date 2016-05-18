using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using SitecoreReference.Services;
using SitecoreReference.Dal;

namespace SitecoreReference.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// </summary>
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<ITeamMemberProfileService, TeamMemberProfileService>();
            container.RegisterType<IClientCommentService, ClientCommentService>();
            container.RegisterType<IServicesService, ServicesService>();
            container.RegisterType<IRecentWorkService, RecentWorkService>();
            container.RegisterType<ILocationService, LocationService>();
            container.RegisterType<IData, InMemoryData>();
            container.RegisterType<IRepository, DummyRepository>(new PerThreadLifetimeManager());
        }
    }
}
