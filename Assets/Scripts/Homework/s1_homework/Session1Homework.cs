using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour
{

    // Session 1 homework

    //exercise of variable_________________________________________________________

    public int sleepActivities = 0;
    public int studyActivities = 0;
    public int leisurActivities = 0;
    public int otherActivities = 0;

    public float myHappyLevel = 10f; 

    public string dailyAssessmentGuide =
        "The percentage of  different activities influence my daily state";


    //exercise of data structure and fuctions_______________________________________

    int[] myPressureLevel = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    Dictionary<string, int> dailyActivity = new Dictionary<string, int>();
   
    void Start () {
        int sleep = 0;
        int study = 1;
        int leisure = 2;
        int other = 3;

        dailyActivity.Add("noon sleep", sleep);
        dailyActivity.Add("night sleep", sleep);
        dailyActivity.Add("unity study", study);
        dailyActivity.Add("c-sharp study", study);
        dailyActivity.Add("reading material", study);
        dailyActivity.Add("game", leisure);
        dailyActivity.Add("meditation", leisure);
        dailyActivity.Add("communication", leisure);
        dailyActivity.Add("transport", other);
        dailyActivity.Add("meals", other);

        if (dailyActivity.ContainsValue(0))
            sleepActivities=dailyActivity.Count;
        if (dailyActivity.ContainsValue(1))
            studyActivities = dailyActivity.Count;
        if (dailyActivity.ContainsValue(2))
            leisurActivities = dailyActivity.Count;
        if (dailyActivity.ContainsValue(3))
            otherActivities = dailyActivity.Count;

        List<string> totalActivityKinds = new List<string>(dailyActivity.Keys);

        int totoalActivities = studyActivities + sleepActivities + leisurActivities + otherActivities;
        float happniessFormula = (float)(studyActivities + otherActivities / totoalActivities)*myHappyLevel;

        System.Console.WriteLine("my happy level today is " + happniessFormula);
    }
}
