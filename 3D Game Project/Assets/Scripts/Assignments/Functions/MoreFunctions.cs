using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreFunctions : MonoBehaviour
{
    public int assignedHomework;
    public int timeForHomework;
    public int time;

    // Start is called before the first frame update
    void Start()
    {
        homework(assignedHomework, timeForHomework, time);
    }

    void homework(int assignedHomework, int timeForHomework, int time)
    {
        int timeSpentOnHomework;
        timeSpentOnHomework = time / (assignedHomework * timeForHomework);
        print(timeSpentOnHomework);
    }
}
