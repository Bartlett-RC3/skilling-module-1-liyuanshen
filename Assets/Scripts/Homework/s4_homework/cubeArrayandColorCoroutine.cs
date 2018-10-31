using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeArrayandColorCoroutine : MonoBehaviour {

    GameObject[] cubeArray;

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
        cubeArray[1] = cube1;
        cubeArray[2] = cube2;
        cubeArray[3] = cube3;
        cubeArray[4] = cube4;
        cubeArray[5] = cube5;
        cubeArray[6] = cube6;

        int i = 1;
        i++;
        colorrender = cubeArray[i].GetComponent<MeshRenderer>();

    }


    void Update()
    {

        StartCoroutine(colorChange);
        Debug.Log(Time.time);

        if (Time.time > 5)
        {
            StopCoroutine(colorChange);
            StopAllCoroutines();

        }
    }


    //implement the corutine
    IEnumerator colorchange()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            colorrender.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
