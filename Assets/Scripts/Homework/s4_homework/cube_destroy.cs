using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cub_destroy : MonoBehaviour
{
    public bool seen ;
    public GameObject cube_s4;

   

    void Update()
    {
        if (seen==true)
        {
            transform.localScale = new Vector3(0, 0, 0);
        }

        seen = false;

    }
}
