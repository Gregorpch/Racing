using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public StopWatch time;
    public RoutePoint finishPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (finishPoint.isActiveForPlayer)
        {
            if (other.tag == "Player")
            {
                time.hasFinished = true;
            }
        }
    }

}
