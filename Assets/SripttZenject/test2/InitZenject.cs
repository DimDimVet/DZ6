using UnityEngine;
using Zenject;

public class InitZenject : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Service");
        Container.Bind<Service1>().AsSingle().NonLazy();
    }
}

