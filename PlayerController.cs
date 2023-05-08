using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;

    public float speed;

    public float xRange;

    public Transform BlasterWork;

   public GameObject Lazer_Bolt;



    // Update is called once per frame
    void Update()
    {
        // Set Hoizontal Input to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

//Moves Player left and right
        transform.Translate(Vector3.right*horizontalInput*Time.deltaTime*speed);
        // Keep player within bonds
        //Left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }
        //right side wall
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
//if space bar is pressed then itll shoot
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Creates LazerBolt at the blaster transdorm potition maintaining the objects rotation.
            Instantiate(Lazer_Bolt, BlasterWork.position, Lazer_Bolt.transform.rotation);
        }

    
    }
    // delete any object with a trigger that hits our player
    private void OnTriggerEnter(Collider other)
 {
    Destroy(other.gameObject);
 }
}
 
