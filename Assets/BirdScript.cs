using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdBody;
    public float flapStrength;
    public float flapSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            birdBody.velocity = Vector2.up * flapStrength;
        }

        if (Input.GetKey(KeyCode.LeftArrow) == true) 
        {
            this.transform.Translate(Vector2.left * flapSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            this.transform.Translate(Vector2.right * flapSpeed * Time.deltaTime);
        }
    }
}
