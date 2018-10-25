using System;

namespace Application
{
    public interface iHuman
    {
        //properties_________________________________________________
        int age { get; set;}
        //here's a propertiy to whether use it or not
        string name { get; set;}

        //Behaviours_________________________________________________
        void Sleeping();
        void Walking();


    }
}
