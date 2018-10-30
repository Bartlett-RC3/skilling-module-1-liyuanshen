using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellattach : MonoBehaviour {
    public GameObject cube;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            cube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
