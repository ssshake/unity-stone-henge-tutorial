using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody Ball;
    public int Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // get input axis y & input axis x
        Ball.AddForce(Input.GetAxis("Horizontal") * Speed, 0, Input.GetAxis("Vertical") * Speed);

        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Jump");
            Ball.AddForce(0, 500, 0);
        }
    }
}
