using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper2 : MonoBehaviour
{

    [SerializeField] private float drop = 15;
    
    MeshRenderer renderer;
    Rigidbody gravity;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        gravity = GetComponent<Rigidbody>();
        gravity.useGravity = false;

    }

    // Update is called once per frame
    void Update(){

     if (Time.time > drop) {

        renderer.enabled = true;
        gravity.useGravity = true;   
        
        }
        
    }
}
