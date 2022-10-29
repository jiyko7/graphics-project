using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float Level (int score)
    {
        int defaultSpeed = -5;
        int increspeed = (score * -1) / 100;
        if (increspeed < -5)
            increspeed = -5;
        return defaultSpeed + increspeed;
    }
}
