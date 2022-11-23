using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Player;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        HandleAnims();
    }

    private void HandleAnims() //PLAYER STATELERE BAKIP ANİMASYONLARI AYARLIYORUZ
    {
        if (Player.PlayerState == PlayerStates.Waiting)
        {
            PlayIdle();
        }
        else if (Player.PlayerState == PlayerStates.Running)
        {
            PlayRun();
        }
        else if (Player.PlayerState == PlayerStates.Falling)
        {
            PlayFall();
        }
        else if (Player.PlayerState == PlayerStates.Win)
        {
            PlayWin();
        }
        else if (Player.PlayerState == PlayerStates.Lost)
        {
            PlayLose();
        }
        
    }
    
    private void PlayIdle()
    {
        animator.SetInteger("AnimNumbers", 0);
    }

    private void PlayRun()
    {
        animator.SetInteger("AnimNumbers", 1);
    }

    private void PlayWin()
    {
        animator.SetInteger("AnimNumbers", 2);
    }

    private void PlayLose()
    {
        animator.SetInteger("AnimNumbers", 3);
    }

    private void PlayFall()
    {
        animator.SetInteger("AnimNumbers", 4);
    }
}
