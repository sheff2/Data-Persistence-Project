using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
   public void RedInput(string s){
        PlayerPrefs.SetString("Current", s);
   }
}
