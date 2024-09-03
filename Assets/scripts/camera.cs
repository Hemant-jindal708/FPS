using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update 
    public Transform playerpos;
    public float offset = -15;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 camerapos = transform.position;
        camerapos.z = playerpos.position.z + offset;
        transform.position = camerapos;
    }
}
