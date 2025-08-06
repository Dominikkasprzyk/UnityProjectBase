using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DependencyInjection
{
    public class RunLifetimeScope : LifetimeScope
    {
        [SerializeField]
        private AppLifetimeScope _appLifetimeScopePrefab;

        protected override void Awake()
        {
            var appLifetimeScope = Find<AppLifetimeScope>();
            if (appLifetimeScope == null && _appLifetimeScopePrefab != null)
            {
                var appScope = Instantiate(_appLifetimeScopePrefab);
                transform.SetParent(appScope.transform);
            }

            base.Awake();
        }

        protected override void Configure(IContainerBuilder builder)
        {
        }
    }
}