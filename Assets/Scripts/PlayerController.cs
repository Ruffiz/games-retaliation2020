using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float moveHorizontal, moveVertical;
    public Rigidbody rb;
    public float angle;
    Vector3 movement;

    public AudioClip gunShot;

    public GunController theGun;

    private void Update()
    {


        if (Input.GetMouseButtonDown(0))
        {
            gameObject.GetComponent<AudioSource>().clip = gunShot;      //Audio
            gameObject.GetComponent<AudioSource>().Play();
        }

        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            moveVertical = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveVertical = -1;
        }
        else
        {
            moveVertical = 0;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveHorizontal = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveHorizontal = -1;
        }
        else
        {
            moveHorizontal = 0;
        }
        movement = new Vector3(moveHorizontal, 0, moveVertical) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        //tilpasse lik hastighet når to knapper trykkes samtidig
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            speed = 7.4f;
        }
        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            speed = 7.4f;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            speed = 7.4f;
        }
        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            speed = 7.4f;
        }
        else
        {
            speed = 10;
        }

        //Snu karakteren mot musepekeren
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);
        Vector2 mouseOnScreen = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
        transform.rotation = Quaternion.Euler(new Vector3(0, (-angle - 90), 0));

        //Skyte kule
        if (Input.GetMouseButtonDown(0)) {
            theGun.isFiring = true;
        }
        if (Input.GetMouseButtonUp(0)) {
            theGun.isFiring = false;
        }
    }
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

}
