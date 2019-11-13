using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class didifall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DidIFall", 0.5f, 0.5f);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DidIFall() {
        if (transform.position.y < -30) {
            transform.position = new Vector3(0, 10, 0);
        }
    }
}
