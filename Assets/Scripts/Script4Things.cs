using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script4Things : MonoBehaviour
{
       public Transform waypoint1;


       public float speed;

    void Start()
       {
        
       }

    void Update()
       {
             //To figre ot the direction, you can subtract two positions together
          Vector2 direction = waypoint1.position - transform.position;
             //direction.y = 0;


             //The vector might be quite long, normalize it to make it the length of 1
          direction.Normalize();


             //We can move an object in some direction, apply some speed to it
          direction = direction * speed * Time.deltaTime;


             //Adding the direction we calculated with the crrent position of the UFO
          transform.position = transform.position + (Vector3) direction;
       }

    private void OnCollisionEnter2D(Collision2D collision)
       {
          if(collision.transform.tag == "Player")
             {
                Destroy(collision.gameObject);

                Destroy(gameObject);
             }
       }
}
