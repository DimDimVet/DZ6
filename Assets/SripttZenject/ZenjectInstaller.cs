using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //Container.Bind<string>().FromInstance("Inject");//создали в контейнере тип стринг и прив€зали значение
        //Container.Bind<TestZenject>().AsSingle().NonLazy();//создали шаблон экземпл€ра, AsSingle() - он один, NonLazy() - запуск сразу по старту

        Container.Bind<IData>().To<TestZenject>().AsSingle().NonLazy();

    }
}
