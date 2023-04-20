using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseToWorld : MonoBehaviour
{
    
    void Start()
    {
       Ray mousePointer = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Update is called once per frame
    void Update() {
        Ray mousePointer = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(mousePointer, out RaycastHit hitInfo, Mathf.Infinity)) {
            Debug.Log(hitInfo.ToString());
        }
    }
}
