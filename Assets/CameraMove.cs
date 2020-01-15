using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
  // public GameObject player;
  Rigidbody rb;

  // Use this for initialization
  void Start ()
  {
    rb = GetComponent<Rigidbody>();
    // player = GameObject.Find("SphereMesh");
  }

  // LateUpdate is called after Update each frame
  void LateUpdate ()
  {
    // float playerY = player.transform.position.y;
    // rb.velocity = new Vector3(0f, playerY, 0f);
  }

  // public void parentCallback(float yPosition) {
  //   //float playerY = player.transform.position.y;
  //   rb.velocity = new Vector3(0f, yPosition, 0f);
  // }
}
