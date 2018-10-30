using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cub_destroy : MonoBehaviour
{
    public bool seen = false;

    void Start()
    {

    }

    void Update()
    {
        if (!seen)
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
       
        seen = false;

    }
}
