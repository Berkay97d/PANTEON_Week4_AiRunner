using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static bool isLevelStarted = false;

    public static void StartGame()
    {
        isLevelStarted = true;
    }
    
}