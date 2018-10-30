using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public Transform movingCube;

    private void Awake()
    {
        Instantiate(movingCube);
        movingCube = (Instantiate(movingCube));
        movingCube.localPosition = new Vector3(Random.value, 0f, 0f);
    }


    void update()
    {

       


    }

}
