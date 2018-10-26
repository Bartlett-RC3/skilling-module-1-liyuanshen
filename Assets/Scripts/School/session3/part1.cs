using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//frames 

public class part1 : MonoBehaviour
{

    ////exist before start________________________________________________________
    //private void Awake()
    //{

    //}

    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;

    public GameObject cubePrefab;
    public GameObject Light;
    // only play/only one time__________________________________________________
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity, this.transform);
            }
        }
    }



    // Update loop!!as far as computer runs_____________________________________
    void Update()
    {

        //time___________________________________________________________________________________________________________
        Debug.Log("this computer can render a fram in:" + Time.deltaTime);
        Debug.Log("since i started playing the game this amout of time has passed" + Time.timeSinceLevelLoad);
        Debug.Log("computer has counted this amout of frames: " + Time.frameCount);



        //translation________________
        //Move children in x-axis_________________________________________________________________________________________

        foreach (Transform child in this.transform)
        {
            child.Translate(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
        }


        //rotation________________________________________________________________________________________________________

        foreach (Transform child in this.transform)
        {
            child.RotateAround(Vector3.up, Random.value);
        }


        //Scaling__________________________________________________________________________________________________________

        foreach (Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(-0.1f, 1), Random.Range(-0.1f, 1), Random.Range(-0.1f, 1));
        }



        //record the cubes orinal scale_____________________________________________________________________________________

        Vector3[] original = new Vector3[this.transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            original[i] = transform.GetChild(i).localScale;
        }


        //keyboard input____________________________________________________________________________________________________

        if (Input.GetKey(KeyCode.Space))
        {
            //if i have pressed space
            foreach (Transform child in this.transform)
            {
                child.localScale = child.localScale * 100f;
            }
        }
        else
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).localScale = original[i];
            }
        }

        //Mouse Pressed (0l,1r,2m)___________________________________________________________________________________________

        if (Input.GetMouseButton(0))
        {
            //if i have pressed space
            foreach (Transform child in this.transform)
            {
                Light.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }
}



//stack overflow for correction______