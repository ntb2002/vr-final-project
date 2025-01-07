using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{
public TextMeshProUGUI canvasText1;
   void Start ()
   {
      Invoke("DisableText", 7f);//invoke after 5 seconds
   }
   void DisableText()
   {
      canvasText1.enabled = false;
   } 
}