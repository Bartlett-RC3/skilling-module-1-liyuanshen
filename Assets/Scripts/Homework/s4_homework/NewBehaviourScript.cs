using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    GameObject[] cubeArray;
    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5; 
    public GameObject cube6;

    IEnumerator colorChange;

    // Use this for initialization
    void Start () {
        cubeArray[1] = cube1;
        cubeArray[2] = cube2;
        cubeArray[3] = cube3;
        cubeArray[4] = cube4;
        cubeArray[5] = cube5;
        cubeArray[6] = cube6;
    }

    // Update is called once per frame
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

            yield return new WaitForSeconds(5);
        }
    }
}
