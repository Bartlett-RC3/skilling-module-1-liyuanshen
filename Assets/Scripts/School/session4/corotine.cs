using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class corotine : MonoBehaviour
{

    public GameObject prefabReference;
    IEnumerator createPrefab;



    // Use this for initialization
    public void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(createPrefab);
        Debug.Log(Time.time);
        if (Time.time >5)
        {
            //StopCoroutine();
            StopAllCoroutines();

        }
    }

    //implement the corutine
    IEnumerator DropPrefabsFromHeight()
    {
        while (true)
        {
            Vector3 prefabPos = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRot = new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), 0);
            GameObject myPrefab = Instantiate(prefabReference, prefabPos, prefabRot);
            yield return new WaitForSeconds(5);
        }
    }
}