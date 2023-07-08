using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GetTest : MonoBehaviour
{

    private IData data;
    private int nomer;
    string dataE;

    [Inject]
    public void Init(IData d)
    {
        data = d;
    }
    // Start is called before the first frame update
    void Start()
    {
        data.ZenjectData();
        data.ZenjectData1();
        //data.ZenjectData2(nomer, out dataE);
        //Debug.Log(dataE);
    }

    // Update is called once per frame
    void Update()
    {
        if (true)
        {
            data.ZenjectData2(nomer, out dataE);
            Debug.Log(dataE);
            nomer++;
        }
    }
}
