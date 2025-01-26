using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Shoot(new Vector3(0, 200, 2000));
        
    }

    // Update is called once per frame
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);  
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
}
