using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foo : MonoBehaviour
{
    private IService _service;

    public Foo(IService service)
    {
        _service = service;
    }

    //metod
    public void LogicService()
    {
        _service.Test();
    }
}
