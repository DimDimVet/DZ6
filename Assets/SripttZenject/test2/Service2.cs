using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service2 : MonoBehaviour,IService
{
    private Service2(string mess)
    {
        Debug.Log(mess);
    }
    public void Test()
    {
        Debug.Log("Service2");
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
