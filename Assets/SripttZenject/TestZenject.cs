using UnityEngine;

public class TestZenject : IData
{

    //private string txt;
    //public TestZenject(string text)
    //{
    //    txt = text;
    //    Debug.Log(text);
    //}
    public void ZenjectData2(int x,out string dataE)
    {
        dataE= $"{x}";
    }
    public void ZenjectData()
    {
        Debug.Log("fff");
    }

    public void ZenjectData1()
    {
        Debug.Log("aaaa");
    }
}
