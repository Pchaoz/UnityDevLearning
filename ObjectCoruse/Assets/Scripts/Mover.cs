using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 8;

    // Start is called before the first frame update
    void Start(){
        
        PrintInstructions();

    }


    // Update is called once per frame
    void Update(){

        MovePlayer();

    }

    void PrintInstructions() {

        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with W,A,S,D or arrow keys");
        Debug.Log("Don't hit the walls");
    
    }

    void MovePlayer() {

        //Variable que guarda el input para moverse a derecha o izquierda todo el rato (x)
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        
        //Variable que guarda el input para moverse a adelant o atras todo el rato (z)
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        //Variable que mueve el jugador
        transform.Translate(xValue, 0, zValue);

    }

}
