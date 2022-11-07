using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IceFall : MonoBehaviour
{
    bool isFalling;
    // Start is called before the first frame update
    void Start()
    {
        isFalling = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -8.26) isFalling = false;
        if (isFalling) transform.position = transform.position + new Vector3(0, -1*Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("iceblock")) {
            isFalling = false;
        }
    }
    public void OnTriggerExit2D(Collider2D other) {
        if (other.gameObject.CompareTag("iceblock")) {
            isFalling = true;
        }
    }
}
