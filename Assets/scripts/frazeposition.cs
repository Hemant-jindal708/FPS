using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frazeposition : MonoBehaviour
{

    private Rigidbody Rbody;

    void Start()
    {
        Rbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstecals")
        {
            Rbody.constraints = RigidbodyConstraints.FreezePosition;
        }
    }

}