using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Parameters")]

    [SerializeField] private float moveSpeed = 10f;

    [SerializeField] private float turnSpeed = 10f;


    [Header("SphereCast Parameters")]

    [SerializeField] private float radius;

    [SerializeField] private float maxDistance;

    [SerializeField] private LayerMask layerGround;

    private RaycastHit hit;


    private Vector3 movement;


    private Rigidbody rigidbody;
 

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        rigidbody = GetComponent<Rigidbody>();
   
    }

    public void ResetMovement(Vector3 position)
    {
        transform.position = position;
        transform.rotation = Quaternion.identity;
        rigidbody.velocity = Vector3.zero;

        print("Respawn");

    }


    private void Update()
    {
        Movement();

        


    }
    /*
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position - transform.up * maxDistance, radius);
    }
    
    */

    private void Movement()
    { 

        //if((transform.rotation.eulerAngles.y >= 60) && (transform.rotation.eulerAngles.y <= 120) || (transform.rotation.eulerAngles.y >= 225) && (transform.rotation.eulerAngles.y <= 315))
        //{
        //    movement = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal"));
        //}else{
            movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //}

        if(movement != Vector3.zero)
        {   
            /*
            if (Physics.SphereCast(transform.position, radius, -transform.up, out hit, maxDistance, layerGround))
            {
                rigidbody.AddForce(new Vector3(0, 0, vertical) * moveSpeed * 300 * Time.deltaTime, ForceMode.Force);
                rigidbody.AddForce(new Vector3(horizontal, 0, 0) * moveSpeed * 100 * Time.deltaTime, ForceMode.Force);
            }

            //print(transform.rotation.eulerAngles.y);
            

            if (Mathf.Abs(horizontal) > 0  && Mathf.Abs(vertical) == 0)
            {
                transform.Rotate(Vector3.up * horizontal * turnSpeed * 30 * Time.deltaTime);
                print(1);
            }else if(Mathf.Abs(horizontal) == 0 && (Mathf.Abs(vertical) > 0) && true)
            {

            } 
            //else if (Mathf.Abs(horizontal) == 0 && Mathf.Abs(vertical) > 0)
            //{
            //    transform.Rotate(-Vector3.up * horizontal * turnSpeed * 100 * Time.deltaTime);

            //}
            */
                
            rigidbody.velocity += movement * moveSpeed * Time.deltaTime;

            if(movement.x != 0){
                transform.Rotate(Vector3.up * Input.GetAxisRaw("Horizontal") * turnSpeed * Time.deltaTime);

            }

            //print(transform.rotation.eulerAngles.y);
        }
        /*

        if (Touch.activeFingers.Count == 1)
        {
            Touch touch = Touch.activeTouches[0];

            if (touch.phase == TouchPhase.Moved)
            {
                float horizontal = Mathf.Abs(touch.delta.normalized.x) > 0.9f ? touch.delta.normalized.x : 0f;
                float vertical = Mathf.Abs(touch.delta.normalized.y) > 0.9f ? touch.delta.normalized.y : 0f;

                Vector3 movement = new Vector3(horizontal, 0, vertical);

                if(movement != Vector3.zero)
                {
                    if (Physics.SphereCast(transform.position, radius, -transform.up, out hit, maxDistance, layerGround))
                    {
                        rigidbody.AddForce(new Vector3(0, 0, vertical) * moveSpeed * 300 * Time.deltaTime, ForceMode.Force);
                        rigidbody.AddForce(new Vector3(horizontal, 0, 0) * moveSpeed * 100 * Time.deltaTime, ForceMode.Force);
                    }

                    //print(transform.rotation.eulerAngles.y);
                    

                    if (Mathf.Abs(horizontal) > 0  && Mathf.Abs(vertical) == 0)
                    {
                        transform.Rotate(Vector3.up * horizontal * turnSpeed * 30 * Time.deltaTime);
                        print(1);
                    }else if(Mathf.Abs(horizontal) == 0 && (Mathf.Abs(vertical) > 0) && true)
                    {

                    } 
                    //else if (Mathf.Abs(horizontal) == 0 && Mathf.Abs(vertical) > 0)
                    //{
                    //    transform.Rotate(-Vector3.up * horizontal * turnSpeed * 100 * Time.deltaTime);

                    //}
                     


                    /*
                    else if (Mathf.Abs(horizontal) == 0 && 
                        (transform.rotation.eulerAngles.y < 10 || transform.rotation.eulerAngles.y > 350))
                    {   
                        transform.Rotate(- Vector3.up * vertical * turnSpeed * 100 * Time.deltaTime);
                        //print(2);

                    }










                    
                    else if(Mathf.Abs(vertical) > 0)
                    {
                        transform.Rotate(Vector3.up * vertical * turnSpeed * 30 * Time.deltaTime);
                    }
                    


                    //if(Mathf.Abs(touch.delta.normalized.x) > .9f)
                    //{


                    // }

                }
                
            }
        
        }
        */
    }
}





 




