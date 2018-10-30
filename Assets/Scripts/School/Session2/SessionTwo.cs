using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SessionTwo : MonoBehaviour {

    //Variabels

    int number1 = 20;
    int number2 = 20;
    bool someBool = false;
    string somename = "a";

    string[] names = { "d", "t", "j", "o", "p" };

    // Use this for initialization
    void Start () {

        //data strucrues_____________________________________________________

        System.Console.WriteLine("a tutor is "+ names[0]);
        System.Console.WriteLine("a tutor is " + names[1]);
        System.Console.WriteLine("a tutor is " + names[2]);
        System.Console.WriteLine("a tutor is " + names[3]);
        System.Console.WriteLine("a tutor is " + names[4]);

        //navigate data using loops

        //iteragtive for loop

        //for loop (variables)taht counts start, where it ends,what is the incerment

        for (int i = 0; i <= names.Length - 1;i++)
        {
            System.Console.WriteLine("a tutor is "+name[i]);
        }

        for (int counter = 0; counter <= number2;counter++)
        {

        };

        //foreach loops
        foreach(string names in names )
        {
            System.Console.WriteLine(names);
        }
















        //conditions__________________________________________________________

        if (number1 < number2) //qusestions
            //action if true

            Debug.Log("number1 is smaller than number2");
        else//action if false
            Debug.Log("number1 is bigger than number2");

        //questions we canask
        // if sth is smlleror larger
        //<,>


        //if sth is qeual to sth else
        //==

        if (number1 <number2&& someBool==true)
        {
            //action
            Debug.Log(" ");
        }


        if (number1<number2 )
        {
            if (someBool ==false)
            {}
        }

        if (number1 < number2 || someBool == false) 
        {

        }

        //complex question by concatenation and by embedding sub questions
        if((number1<number2 && someBool==true)&&(someBool==true &&somename=="name"))
        {}
        //not recommand

        Debug.Log("it's too confusing!simply please!");

        //shorthand if//conditional operator: (a?b:c);
        number2 = (number1 < number2) ? 100:200;







    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
