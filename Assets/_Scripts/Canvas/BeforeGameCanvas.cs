using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeforeGameCanvas : MonoBehaviour
{
    private static BeforeGameCanvas Instance { get; set; }

    private void Awake()
    {
        Instance = this;
    }

    public static void EnableCanvas()
    {
        Instance.gameObject.SetActive(true);
    }
    
    public static void DisableCanvas()
    {
        Instance.gameObject.SetActive(false);
    }
}
