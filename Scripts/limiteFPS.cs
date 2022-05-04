using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limiteFPS : MonoBehaviour
 {
     public int targetFrameRate = 60;
 
     private void Start()
     {
         QualitySettings.vSyncCount = 0;
         Application.targetFrameRate = targetFrameRate;
     }
     // Update is called once per frame
    void Update()
    {
        
        
    }
}
