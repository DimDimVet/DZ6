using UnityEngine;
using Zenject;

public class ZenjectInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<string>().FromInstance("Inject");//������� � ���������� ��� ������ � ��������� ��������
        Container.Bind<TestZenject>().AsSingle().NonLazy();//������� ������ ����������, AsSingle() - �� ����, NonLazy() - ������ ����� �� ������
    }
}

public class TestZenject
{
    public TestZenject(string text)
    {
        Debug.Log(text);
    }
}