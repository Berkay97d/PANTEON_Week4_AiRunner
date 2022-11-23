using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCanvasHandler : MonoBehaviour
{
    private void Update()
    {
        HandleCanvas();
    }

    private void HandleCanvas()
    {
        if (GameController.isLevelStarted)
        {
            BeforeGameCanvas.DisableCanvas();
            InputCanvas.EnableCanvas();
        }
        else if (!GameController.isLevelStarted)
        {
            BeforeGameCanvas.EnableCanvas();
            InputCanvas.DisableCanvas();
        }
    }

    
}
