using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public float speed = 1f;
    public float rotationSpeed = 1f;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");



        float alturaInput = Input.GetAxis("Altura");
        Vector3 direction = new Vector3(-1, alturaInput, horizontalInput);
        direction.Normalize();
        //transform.position += direction * speed * Time.deltaTime;
        rigidbody.velocity = direction * speed * Time.deltaTime;

        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(rotationY * Time.deltaTime * rotationSpeed, 0, 0));

      
    }
}
