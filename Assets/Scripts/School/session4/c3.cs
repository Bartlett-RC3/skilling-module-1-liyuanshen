using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c3 : MonoBehaviour
{
    public bool seen = false;

    void Start()
    {

    }

    void Update()
    {
        if (!seen)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
        seen = false;

    }
}
