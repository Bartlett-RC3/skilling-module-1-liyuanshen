using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crazycubs2 : MonoBehaviour
{
    public int number=20;

    public int widthRange=10;
    public int heightRange=10;
    public int lengthRange=10;

    public int xRange=100;
    public int yRange=100;
    public int zRange=100;

    public int RValue;
    public int GValue;
    public int BValue;



    // Use this for initialization
    void Update()
    {



        for (int i = 0; i <= number; i++)
        {
            GameObject ObjectCubs = GameObject.CreatePrimitive(PrimitiveType.Cube);

            //GameObject ObjectCubs = GameObject.CreatePrimitive.(); Is it possible to create random 3d objs??


            var width = Random.Range((float)0, (float)widthRange);
            var height = Random.Range((float)0, (float)lengthRange);
            var length = Random.Range((float)0, (float)lengthRange);

            var x = Random.Range((float)0, (float)xRange);
            var y = Random.Range((float)0, (float)yRange);
            var z = Random.Range((float)0, (float)zRange);

            var R = Random.value;
            var G = Random.value;
            var B = Random.value;



            //ObjectCubs.transform.localScale = new Vector3(Random.Range((float)0, (float)1), Random.Range((float)0, (float)1), Random.Range((float)0, (float)1));
            //ObjectCubs.transform.position = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
            //ObjectCubs.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);


            ObjectCubs.transform.localScale = new Vector3(width, height, length);
            ObjectCubs.transform.position = new Vector3(x, y, z);
            ObjectCubs.GetComponent<Renderer>().material.color = new Color(R, G, B);

            //ObjectCubs.transform.localPosition = new Vector3(0,10,0);

            //ObjectCubs.GetComponent<Renderer>().material.color = new Color(Random.Range(0, 225), Random.Range(0, 225), Random.Range(0, 225));





            //Instantiate(ObjectCubs);


            //(To Controal the distance betwwen cubes a conditional statements are required here)


        }
    }
}


//so how can everthing be control at runtime??
//how random object can be controled???
