using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class cubeArrayandColorCoroutine : MonoBehaviour {

    GameObject[] cubeArray = new GameObject[6];

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5; 
    public GameObject cube6;


    private MeshRenderer colorrender;

    IEnumerator colorChange;
    // add cube to cubeArray

    void Start () {
        cubeArray[0] = cube6;
        cubeArray[1] = cube1;
        cubeArray[2] = cube2;
        cubeArray[3] = cube3;
        cubeArray[4] = cube4;
        cubeArray[5] = cube5;

        colorChange = colorchange();



        StartCoroutine(colorChange);
    }


    void Update()
    {

       
        Debug.Log(Time.time);

       
    }


    //implement the corutine
    IEnumerator colorchange()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);

            for (int i = 0; i < 6; i++)
            {
                colorrender = cubeArray[i].GetComponent<MeshRenderer>();

                colorrender.material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);

            }


            if (Time.time > 5)
            {
                StopCoroutine(colorChange);
                StopAllCoroutines();

            }
        }
    }
}
