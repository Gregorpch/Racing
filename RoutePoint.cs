using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using Unity.VisualScripting;
using UnityEngine;

public class RoutePoint : MonoBehaviour
{
    public RoutePoint nextPoint;

    private GameObject model;

    public bool isActiveForPlayer;

    private void Start()
    {
        model = gameObject;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            if (isActiveForPlayer) 
            {
                isActiveForPlayer = false;
                model.SetActive(false);

                if (nextPoint != null)
                {
                    nextPoint.isActiveForPlayer = true;
                    nextPoint.model.SetActive(true);
                }
            }
        }
    }


}
