using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class SubmarinControl : MonoBehaviour

{
    [SerializeField] private float Vitesse;
    [SerializeField] private float verticalSpeed;


    private Rigidbody rb;

    private float Direction;

    private Animator animator;

    private float MovementVertical;

    // Start is called before the first frame update
    void Start()
    {
        

       rb = GetComponent<Rigidbody>();
       animator = GetComponent<Animator>();


    }


    void OnMovementx(InputValue Directionx)
    {


        Direction = Directionx.Get<float>();

        if(Direction !=0){

            Vitesse = 0.35f;


        }

        else{Vitesse=0;}





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



         MovementVertical = Directiony.Get<float>();

        if(MovementVertical != 0)
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



        Vitesse = 0.35f * 2;
            
        animator.SetBool("Vitesse shift", true);
        
        
        
        Debug.Log("go fast");


        }



        else{

            Vitesse = 0.35f;

            animator.SetBool("Vitesse shift", false);

            Debug.Log("go slow");

        }


    }


    // Update is called once per frame
    void FixedUpdate()
    {


        Vector3 DirectionBouger = Direction * Vitesse * transform.forward;

        rb.AddForce(DirectionBouger, ForceMode.VelocityChange);

        Vector3 BougerVertical = Vector3.up * verticalSpeed * MovementVertical;
        rb.AddForce(BougerVertical, ForceMode.VelocityChange);


        animator.SetFloat("vitesse", Vitesse);
    }

}
