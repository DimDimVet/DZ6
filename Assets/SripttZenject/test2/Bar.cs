using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    IService _service;

    public Bar(IService service)
    {
        _service = service;
    }
    public void LogicService()
    {
        Foo foo = new Foo(_service);
    }
}
