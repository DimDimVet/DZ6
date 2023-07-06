using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GetTest : MonoBehaviour
{

    private IData data;

    [Inject]
    public void Init(IData d)
    {
        data = d;
    }
    // Start is called before the first frame update
    void Start()
    {
        data.ZenjectData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
