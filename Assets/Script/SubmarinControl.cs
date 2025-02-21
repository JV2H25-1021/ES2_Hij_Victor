using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SubamrinControl : MonoBehaviour

{
    [SerializeField] public float vitesse;



    private Rigidbody rb;

    private Vector3 Direction;

    private Animation animator;


    // Start is called before the first frame update
    void Start()
    {
        

       rb = GetComponent<Rigidbody>();
       animator = GetComponent<Animation>();

    }


    void OnMovementx(InputValue Directionx)
    {


       





       

        Debug.Log("go front");
 
    }


    void OnMovementy(InputValue Directiony)
    {

        Debug.Log("Go up");

        

    }

    void OnSPEED(InputValue Shift)
    {





        Debug.Log("go fast");


    }


    // Update is called once per frame
    void FixUpdate()
    {
        





    }



}
