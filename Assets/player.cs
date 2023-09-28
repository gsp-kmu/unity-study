using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public GameObject bullet;
    public GameObject background1;
    public GameObject background2;
    public float fSpeed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.D))  transform.position += fSpeed * new Vector3(3.0f, 0, 0) * Time.deltaTime;
        if (Input.GetKey(KeyCode.A)) transform.position -= fSpeed * new Vector3(3.0f, 0, 0) * Time.deltaTime;
        

        if(Input.GetKeyDown(KeyCode.W))
            rigidbody2D.AddForce(new Vector3(0,500,0));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bullet);
            newBullet.transform.position = transform.position;
            Destroy(newBullet, 3);
        }

        background1.transform.position -= fSpeed * new Vector3(0.5f, 0, 0) * Time.deltaTime;
        background2.transform.position -= fSpeed * new Vector3(0.5f, 0, 0) * Time.deltaTime;

        if(background1.transform.position.x < -6)
        {
            background1.transform.position += new Vector3(12f, 0, 0);
        }

        if (background2.transform.position.x < -6)
        {
            background2.transform.position += new Vector3(12f, 0, 0);
        }
    }
}
