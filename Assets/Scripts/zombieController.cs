using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieController : MonoBehaviour {

    public float speed;
    public float moveHorizontal, moveVertical;
    public Rigidbody rb;
    public float angle;
    Vector3 movement;

    public AudioClip gunShot;

    private void Update()
    {
        if (Input.GetKey(KeyCode.G))
        {
            transform.Rotate(new Vector3(0, 10, 0));
        }

        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<AudioSource>().clip = gunShot;      //Audio
            gameObject.GetComponent<AudioSource>().Play();
        }

        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1;
            //gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1;
            // gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * -speed);
        }
        else
        {
            moveVertical = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1;
            //gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.right * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1;
            //gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.right * -speed);
        }
        else
        {
            moveHorizontal = 0;
        }
        movement = new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        //Snu karakteren mot musepekeren
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 mouseOnScreen = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
        transform.rotation = Quaternion.Euler(new Vector3(0, (-angle - 90), 0));

    }
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

}

