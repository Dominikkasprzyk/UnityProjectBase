using MessagePipe;
using UnityEngine;
using UnityEngine.InputSystem;
using VContainer;
using VContainer.Unity;

namespace DependencyInjection
{
    public class AppLifetimeScope : LifetimeScope
    {
        [SerializeField]
        private InputActionAsset _inputActionAsset;

        protected override void Awake()
        {
            DontDestroyOnLoad(gameObject);
            base.Awake();
        }

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(_inputActionAsset)
                .As<InputActionAsset>();

            builder.RegisterMessagePipe();
        }
    }
}