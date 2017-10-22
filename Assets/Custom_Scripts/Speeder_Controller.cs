using UnityEngine;
using System.Collections;

public class Speeder_Controller : MonoBehaviour {

    private KeyCode previouslyPressed = 0;
    private Rigidbody speederBody;
    private GameObject speeder;
    public float torque;
    public float thrust;


	// Use this for initialization
	void Start () {
        speeder = GameObject.Find("Speeder");
        speederBody = speeder.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.A)) {
            
        }

        if (Input.GetKey(KeyCode.D))
        {
            
        }

        if (Input.GetKey(KeyCode.W))
        {
            //bank left
            speederBody.AddForce(transform.right * thrust);
            //Accelerate/continue accelerating
        }

        if (Input.GetKey(KeyCode.S))
        {
            //backward accel (mild)
            //bank right
            speederBody.AddForce(-transform.right * thrust);
        }

    }
}
