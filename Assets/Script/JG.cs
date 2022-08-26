using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JG : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject cac;
    //Use this for initialization
    void Start()
    {
        InvokeRepeating("a", 1, 1.3f); 
    }
    // Update is called once per frame
    void Update()
    {
        

    }
    void a()
    {
        Spawn = Instantiate(cac, transform.position, Quaternion.identity) as GameObject;
    }
}

