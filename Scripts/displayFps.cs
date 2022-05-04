 using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 
 public class displayFps : MonoBehaviour {
     public Text fpsText;
     public float deltaTime;

     public bool showFps = false;
 
     void Update () {
         if(showFps) {
             deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
             float fps = 1.0f / deltaTime;
             fpsText.text = Mathf.Ceil (fps).ToString ();
         }
     }
 }