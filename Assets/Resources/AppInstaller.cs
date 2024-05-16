using UnityEngine;
using Zenject;

public class AppInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Foo>().AsSingle();
        Container.Bind<IBar>().To<Bar>().AsSingle();
    }
}