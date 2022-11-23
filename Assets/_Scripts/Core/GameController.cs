using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Player;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static bool isLevelStarted = false;

    public static void StartGame() //START GAME BUTONUNA ATANDI, KULLANILMIYOR ŞUAN AMA BELKİ LAZIM OLUR
    {
        isLevelStarted = true;
    }
    
}
