using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoManager : MonoBehaviour
{
    public static int ammo;

    public static void AddPoints(int pointsToAdd)
    {
        ammo += pointsToAdd;
        Debug.Log("Total Ammo " + ammo);
    }
}
