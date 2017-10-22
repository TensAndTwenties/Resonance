using UnityEngine;
using System.Collections;

public class Suspension : MonoBehaviour {

    public float springForce;
    public float dampingForce;
    public float springConstant;
    public float dampingConstant;
    public float restLength;

    public Rigidbody rb;

    private float prevLength;
    private float currentLength;
    private float springVelocity;
	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponentInParent<Rigidbody>();
        springConstant = rb.mass * 15;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(transform.position, -transform.up, out hit ,restLength)) {
            prevLength = currentLength;
            currentLength = restLength - (hit.distance);
            springVelocity = (currentLength - prevLength) / Time.fixedDeltaTime;
            springForce = springConstant * currentLength;
            dampingForce = dampingConstant * springVelocity;

            rb.AddForce(transform.up * (springForce + dampingForce));
        }
	}
}
