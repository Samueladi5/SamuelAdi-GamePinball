using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>(); // Use 'rig' instead of 'rigidbody'
    }

    // Update is called once per frame
    void Update()
    {
        if (rig.velocity.magnitude > maxSpeed) // Use 'maxSpeed' instead of 'masSpeed'
        {
            rig.velocity = rig.velocity.normalized * maxSpeed; // Correct the assignment here
        }
    }
}
