using UnityEngine;

public class TestZenject : IData
{
    //private string txt;
    //public TestZenject(string text)
    //{
    //    txt = text;
    //    Debug.Log(text);
    //}

    public void ZenjectData()
    {
        Debug.Log("fff");
    }
}

public interface IData
{
    void ZenjectData();
}
