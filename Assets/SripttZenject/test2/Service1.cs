using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service1 : MonoBehaviour,IService
{
    private Service1(string mess)
    {
        Debug.Log(mess);
    }
    public void Test()
    {
        Debug.Log("Service1");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
