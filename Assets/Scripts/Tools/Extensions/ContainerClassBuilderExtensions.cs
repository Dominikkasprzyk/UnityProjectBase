using VContainer;

namespace Tools.Extensions
{
    public static class ContainerClassBuilderExtensions
    {
        public static void RegisterScopedInstance<T>(this IContainerBuilder builder, T instance) where T : class
        {
            builder.Register(_ => instance, Lifetime.Singleton)
                .AsSelf()
                .AsImplementedInterfaces();

            builder.RegisterBuildCallback(resolver => { resolver.Resolve<T>(); });
        }
    }

    public static class ContainerBuilderStructExtensions
    {
        public static void RegisterScopedInstance<T>(this IContainerBuilder builder, T instance) where T : struct
        {
            builder.Register(_ => instance, Lifetime.Singleton)
                .AsSelf()
                .AsImplementedInterfaces();

            builder.RegisterBuildCallback(resolver => { resolver.Resolve<T>(); });
        }
    }
}