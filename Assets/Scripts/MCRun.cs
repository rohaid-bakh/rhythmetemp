using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCRun : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidbody2d;
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float horizontal = 1;
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;
       position.x = position.x + 3.0f * horizontal * Time.deltaTime;
       position.y = position.y + 3.0f * vertical * Time.deltaTime;
       transform.position = position;
       if (Input.GetKeyDown(KeyCode.UpArrow)) {
           float jumpVelocity = 10f;
           rigidbody2d.velocity = Vector2.up * jumpVelocity;
       }
    }
}
