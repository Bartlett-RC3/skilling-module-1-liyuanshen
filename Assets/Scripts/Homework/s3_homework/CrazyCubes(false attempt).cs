using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CrazyCubesWrongAttampt : MonoBehaviour {



    public float number=20;

    public float widthRange=10;
    public float heightRange=10;
    public float lengthRange=10;

    public float xRange=5;
    public float yRange=5;
    public float zRange=5;

    public float aValue=10;


    public  void start()
    {

    }


    void update()
    {
        for (int i = 0; i <= number; i++)
        {
            GameObject ObjectCubes = GameObject.CreatePrimitive(PrimitiveType.Cube); 

            var width = Random.Range(0f, Random.Range(0f, widthRange));
            var height = Random.Range(0f, Random.Range(0f, heightRange));
            var length = Random.Range(0f, Random.Range(0f, lengthRange));

            var x = Random.Range(0, xRange);
            var y = Random.Range(0, yRange);
            var z = Random.Range(0, zRange);

            var R = Random.value;
            var G = Random.value;
            var B = Random.value;

            var a = Random.Range(0, aValue);
            var b = 0f;
            var c = 0f;


            ObjectCubes.transform.localScale = new Vector3(width, height, length);
            ObjectCubes.transform.position = new Vector3(x, y, z);
            ObjectCubes.transform.GetComponent<Renderer>().material.color = new Color(R, G, B);
            //ObjectCubes.transform.localPosition = new Vector3(a,b,c);
        }





        }

}
