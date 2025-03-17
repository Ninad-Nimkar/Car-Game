using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public Camera hoodcamera;
    public Camera maincamera;
    public KeyCode switchkey;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20;
    private float turnSpeed = 25f;
    private float Horizontalinput;
    private float Forwardinput;
    // Update is called once per frame
    void Update()
    {
        // Axis setup
        Horizontalinput = Input.GetAxis("Horizontal");
        Forwardinput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * Forwardinput);
        // Rotate the vehicle left and right
        transform.Rotate(Vector3.up, turnSpeed * Horizontalinput * Time.deltaTime);
        if (Input.GetKeyDown(switchkey))
        {
            maincamera.enabled = !maincamera.enabled;
            hoodcamera.enabled = !hoodcamera.enabled;
        }
    }


}
