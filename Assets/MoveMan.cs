using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveMan : MonoBehaviour
{
    public bool onGround;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      onGround = false;
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      if (onGround) {
        if (Input.GetButtonDown("Jump")) {
          rb.velocity = new Vector3(0f, 5f, 0f);
          onGround = false;
        }
      }
    }

    void OnCollisionEnter(Collision other) {
      if (other.gameObject.CompareTag("Ground")) {
        onGround = true;
      }
    }
}
