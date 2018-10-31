using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cub_destroy : MonoBehaviour
{
    public bool seen = true;

   

    void Update()
    {
        if (!seen)
        {
            transform.localScale = new Vector3(0.0000001f, 0.000001f, 0.000001f);
        }

        seen = false;

    }
}
