using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Player;
using UnityEngine;

public class Obstacle3 : MonoBehaviour
{
    [SerializeField] private float jumpForce;

    public List<GameObject> targets = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        targets.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        targets.Remove(other.gameObject);
    }

    public void JumpTargets() //OBSTACLE'IN ANİMASYONUNDA EVENT İLE ÇAĞIRILDI
    {
        if (targets.Count == 0) //ZIPLATICAK Bİ ŞEYİN YOKSA KAPAT
        {
            return;
        }
        foreach (var target in targets)
        {
            if (target.TryGetComponent(out PlayerController playerController)) //TARGET'IM PLAYERSA ZIPLAT 
            {
                playerController.MakePlayerJump(jumpForce);
            }
            
        }
    }
}
