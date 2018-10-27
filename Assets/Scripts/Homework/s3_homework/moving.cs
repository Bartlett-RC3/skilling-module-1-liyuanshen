using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public GameObject cubePrefab;

    public void  Start()
    {
        Instantiate(cubePrefab, new Vector3(0, 0, 0), Quaternion.identity, this.transform);
    }

    void update() {

        foreach (Transform child in this.transform)
        {
            child.localPosition=new Vector3(Random.Range(0,10f), 0, 0);
        }

        foreach (Transform child in this.transform)
        {
            child.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
        }
    }


}
