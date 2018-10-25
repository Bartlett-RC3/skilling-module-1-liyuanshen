////Interface

////the libary we useing________________________________________________________
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


////initial class provide by unity
//public class s1classexampels : MonoBehaviour {

//	// Use this for initialization
//	void Start () {

//	}

//	// Update is called once per frame
//	void Update () {

//	}
//}




using UnityEngine;
using SlyWorld;

//my custome class(object)

namespace SlyWorld
{
    public class Humans : MonoBehaviour//L-click-refector-rename
    {
        //properties

        string objectname = "Oct";
        int age = 32;
        float height = 170.5f;
        float energy = 100;

        //behavious

        //void walking() { };
        //void sleeping() { };
        //void eating() { };

        void WorkingOut()
        {

        }

    }
}