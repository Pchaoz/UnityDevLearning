using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 15;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //Variable que guarda el input para moverse a derecha o izquierda todo el rato (x)
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        
        //Variable que guarda el input para moverse a adelant o atras todo el rato (z)
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


        transform.Translate(xValue, 0, zValue);

    }
}
