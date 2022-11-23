using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCanvas : MonoBehaviour
{
   private static InputCanvas Instance { get; set; }
    
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
