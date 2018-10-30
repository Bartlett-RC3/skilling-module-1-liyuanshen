using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingandColorchanging : MonoBehaviour {

    public GameObject cube;
    float  i= 0;

    // Use this for initialization
    void Start () {

        cube.transform.position = new Vector3(0, 0, 0);

    }
	
	// Update is called once per frame
	void Update () {


        if (Time.realtimeSinceStartup>=0)
        {

            cube.transform.localPosition = new Vector3(0.1f+i/10, 0f, 0f);
            i++;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            cube.GetComponent<Renderer>().material.color=new Color (Random.value,Random .value ,Random.value);
        }
    }
}

 