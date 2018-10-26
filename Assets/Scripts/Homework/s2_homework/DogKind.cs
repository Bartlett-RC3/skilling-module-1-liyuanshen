using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

public class DogKind {

    int smallDogs = 1;
    int mediumDogs = 2;
    int largeDogs = 3;

    public Dictionary<string, int> DogDictionary = new Dictionary<string, int>();

    public void Start () {

        DogDictionary.Add("Dachshouds", smallDogs);
        DogDictionary.Add("Small Terries", smallDogs);
        DogDictionary.Add("Bulldog", mediumDogs);
        DogDictionary.Add("Whippet", mediumDogs);
        DogDictionary.Add("Leonberger", largeDogs);
        DogDictionary.Add("Greyhound", largeDogs);

        if (DogDictionary.ContainsValue(1)) 
        {
            Console.WriteLine("it is a small dogs");
        }

        if (DogDictionary.ContainsValue(2))
        {
            Console.WriteLine("it is a medium dogs");
        }

        if (DogDictionary.ContainsValue(3))
        {
            Console.WriteLine("it is a large dogs");
        }

    }
	
}
