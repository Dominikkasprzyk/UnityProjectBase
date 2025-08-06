using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace DependencyInjection
{
    public class GameplayLifetimeScope : LifetimeScope
    {
        [SerializeField]
        private RunLifetimeScope _runLifetimeScopePrefab;

        protected override void Awake()
        {
            var runLifetimeScope = Find<RunLifetimeScope>();
            if (runLifetimeScope == null && _runLifetimeScopePrefab != null)
            {
                runLifetimeScope = Instantiate(_runLifetimeScopePrefab);
            }

            base.Awake();
            transform.SetParent(runLifetimeScope.transform);
        }

        protected override void Configure(IContainerBuilder builder)
        {
        }
    }
}