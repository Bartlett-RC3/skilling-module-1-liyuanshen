using System;
using System.Collections.Generic;

public class Main : DogKind{

    List<string> Dogs = new List<string>();

    public int numberOfDogs = Convert.ToInt32(Console.ReadLine());
    public int numberOfhumans= Convert.ToInt32(Console.ReadLine());


    void Evaluate () {
        //fuction:evaluation relationship with human____________________________

        if (numberOfDogs<=numberOfhumans )
        {
            Console.WriteLine("balenced relationship");
        }
        else
        {
            Console.WriteLine("unblenced relationship");
        }

        //list dog names________________________________________________________

        Dogs.Add("John");
        Dogs.Add("Niki");
        Dogs.Add("Prince");
        Dogs.Add("Sisi");
    
        int number = Dogs.Count - 1;

        for (var i = 1; i <= number; i++)
        {
            Console.WriteLine("the name of dog is " + Dogs[i]);
        }

        //provide choice of dogkinds
        bool needSmallDogs=Convert.ToBoolean(Console.ReadLine());
        bool needMediumDogs= Convert.ToBoolean(Console.ReadLine());
        bool needLargedogs= Convert.ToBoolean(Console.ReadLine());

        if (needSmallDogs==true)
        {
            Console.WriteLine("dogKinds can be choosen is" + DogDictionary.ContainsValue(1));
        }

        if (needMediumDogs == true)
        {
            Console.WriteLine("dogKinds can be choosen is" + DogDictionary.ContainsValue(2));
        }

        if (needLargedogs == true)
        {
            Console.WriteLine("dogKinds can be choosen is" + DogDictionary.ContainsValue(3));
        }

    }


}
