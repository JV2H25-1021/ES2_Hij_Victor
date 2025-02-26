using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SubamrinControl : MonoBehaviour

{
    [SerializeField] private float Vitesse;



    private Rigidbody rb;

    private Vector3 Direction;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        

       rb = GetComponent<Rigidbody>();
       animator = GetComponent<Animator>();

    }


    void OnMovementx(InputValue Directionx)
    {

        Vector2 vitesse = Directionx.Get<Vector2>() * Vitesse;
          Direction = new Vector3(vitesse.x, vitesse.y, 0f);




        if (Directionx.isPressed)
        {
            animator.SetFloat("vitesse", Vitesse);
        }

        else
        {
            animator.SetFloat("vitesse", 0);
        }
            Debug.Log("go front");
 
    }


    void OnMovementy(InputValue Directiony)
    {







        if(Directiony.isPressed)
        {

            animator.SetBool("MovementY", true);

        }


        else{
            animator.SetBool("MovementY", false);
        }
        Debug.Log("Go up");

    }

    void OnSPEED(InputValue Shift)
    {

        if(Shift.isPressed){




        animator.SetBool("Vitesse shift", true);
        
        
        
        Debug.Log("go fast");


        }



        else{

            animator.SetBool("Vitesse shift", false);

            Debug.Log("go slow");

        }


    }


    // Update is called once per frame
    void FixUpdate()
    {

        Vector3 movement = Direction;

        rb.AddForce(movement, ForceMode.VelocityChange);
        


        animator.SetFloat("vitesse", 4);
    }

}
