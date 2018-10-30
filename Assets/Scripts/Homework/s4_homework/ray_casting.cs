using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ray_casting : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //ray casting steps

        //s1:Create ray

        Vector3 raycastingDirection = transform.forward;

        //s2: see hat object is in front of me

        RaycastHit objectInFront;

        //s3:do soething with the object in front of me

        if (Physics.Raycast(transform.position, raycastingDirection, out objectInFront))
        {
            Debug.Log("Object in front is" + objectInFront.transform.name);
            objectInFront.transform.GetComponent<cub_destroy>().seen = true;



        }

    }
}
