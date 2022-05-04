using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleComportament : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
         // Comando para agrandar el objeto
    {
        if (gameObject.transform.localScale.x > -500)  InvokeRepeating("changeScaleDown", 0.8f, 0.08f);
    }
    void changeScaleDown(){
        
        if (gameObject.transform.localScale.x > -500) {
            gameObject.transform.localScale += new Vector3(0.2f * Time.deltaTime, 0.2f * Time.deltaTime, 0.2f * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Comando para achicar el objeto
        if (Input.GetKey("space")){
        gameObject.transform.localScale -= new Vector3(0.5f * Time.deltaTime, 0.5f * Time.deltaTime, 0.5f * Time.deltaTime);
    }
    }
}
