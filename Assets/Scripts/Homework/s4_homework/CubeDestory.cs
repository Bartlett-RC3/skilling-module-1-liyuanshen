using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestory : MonoBehaviour
{
    public bool seen;
    public GameObject cube_s4;



    void Update()
    {
        if (seen == true)
        {
            transform.localScale = new Vector3(0, 0, 0);

        }


        //else

        ////if (seen == false)
        //{
        //    transform.localScale = new Vector3(1, 1, 1);

        //}
        seen = false;




    }
}
