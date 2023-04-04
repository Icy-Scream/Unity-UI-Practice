using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();  
        Destroy(gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {


        rb.AddRelativeForce(new Vector3(0, 0,3));

    }
}
