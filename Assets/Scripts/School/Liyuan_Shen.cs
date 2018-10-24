using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liyuan_shen : MonoBehaviour
{


    //1.variables______________________________________________________________
    //Scope(public/private)--type--name--value(just one value)

    //Numbers
    //int whole numbers
    //double nummbers with "." 16digits
    //float 64 digits

    int myInteger = 145;
    int largestInteger = int.MaxValue;
    int smallestINteger = int.MinValue;

    double myDouble = 54.3;
    double largestDouble = double.MaxValue;

    float myFloat = 32.456f;//more digits than doulbes;rember to add f

    //text
    string myString = "this is the new awesome rc3! Better than ever;)";

    //Logical
    bool myBoolean = true;
    bool falseBaoolean = false;


    //2.Data Structures;_______________________________________________________
    //Scope--type--values(can take in many values)

    //Array(order;size)
    int[] myIntArray = { 1, 2, 3, 4, 5, 6 };
    int[] twentyElementsArray = new int[20];//start form 0;no=null;
    int[,] xyArray = new int[4, 5];//grid with 4 in x; 5 in y//2-dimations//unit can be whatever
                                   //typology in graph

    double[] doubleArray = { 10.1, 11.2, 12.3, 13.4, 13.0 };//int<double<float

    //List(more free, don't know how many will be inside)
    List<int> myList = new List<int>();//make a list named my list and put fuction in ();
                                       //read English code in English;


    //Dictionary(infomation+how it is organized)
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>;
    //tkey:how you want to orgnize;both key/value need a type def.
    //abstrcuion as number/values;


    //3.Fuctions_______________________________________________________________
    //Scope--type(void,int,float,double,bool,etc.)--Value--Body


    // Use this for initialization
    void Start()
    {
        //Array adding values
        myIntArray[2] = 300;

        //Array retrive value
        Debug.Log(myIntArray[1].ToString());

        //_______________________________________________


        //List add value(only can be add at the end);
        myList.Add(4321);

        //List retrive value(whatever position);
        //Debug.Log(myList[2].ToString);--error:not exist

        myList.Add(4321);
        myList.Add(32);

        Debug.Log(myList[myList.Count - 1].ToString());

        //clearing the list
        myList.Clear();

        //_______________________________________________


        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("fling", "parrot");
        movingAnimals.Add("walking", "human");
        movingAnimals.Add("walking", "dog");

        if (movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("A flying animals is " + movingAnimals.Values);
        }
    }

    // __________________________________________________


    void Update()
    {
        myFloat = 13.4f;
    }
    //number addtion fuction
    float NumberAddition(float a, float b)
    {
        return a + b;
    }


    void PrintSomeNubers()
    {
        Debug.Log(myList[0]);
        Debug.Log(myInteger);
    }
}