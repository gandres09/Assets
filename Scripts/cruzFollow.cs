using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cruzFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = transform;
        }

        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 1;
        //el objeto estara en la posicion del mouse
        target.position = mouseWorldPosition;
    }
}
