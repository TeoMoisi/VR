using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereJump : MonoBehaviour
{
  // public bool onGround;
  // public float movementSpeed = 0.10f;
  // Rigidbody rb;
  // public GameObject camera;
  // public CameraMove cameraMove;
  //public GameObject player;

  // Start is called before the first frame update
  void Start()
  {
    // onGround = false;
    // rb = GetComponent<Rigidbody>();
    // camera = GameObject.Find("CameraMesh");
    // cameraMove = camera.GetComponent<CameraMove>();
    //player = GameObject.Find("Sphere");
  }

  // Update is called once per frame
  void Update()
  {
    // if (onGround) {
    //   if (Input.GetButtonDown("Jump")) {
    //     rb.velocity = new Vector3(0f, 5f, 0f);
    //     onGround = false;
    //
    //   }
    // }
    // if (Input.GetKey(KeyCode.LeftArrow)) {
    //   rb.velocity = new Vector3(1f, 0f, 0f);
    // }
    // if (Input.GetKey(KeyCode.DownArrow)) {
    //   rb.velocity = new Vector3(0f, 0f, 1f);
    // }
    // if (Input.GetKey(KeyCode.RightArrow)) {
    //   rb.velocity = new Vector3(-1f, 0f, 0f);
    // }
    // if (Input.GetKey(KeyCode.UpArrow)) {
    //   rb.velocity = new Vector3(0f, 0f, -1f);
    // }
    // float positionY = transform.position.y - camera.transform.position.y;
    // cameraMove.parentCallback(positionY);

  }

  // void OnCollisionEnter(Collision other) {
  //   if (other.gameObject.CompareTag("Ground")) {
  //     onGround = true;
  //     // float positionY = player.transform.position.y - camera.transform.position.y;
  //     // cameraMove.cameraCallback(positionY);
  //   }
  // }
}
