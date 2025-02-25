using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
       public float speed = 5f;


       private float timeElapsed = 0f;

    // Start is called before the first frame update
    void Start()
       {
        
       }

    // Update is called once per frame
    void Update()
       {
           transform.position += transform.right * speed * Time.deltaTime;


           timeElapsed += Time.deltaTime;


           if(timeElapsed > 5f)
           {
               Destroy(gameObject);
           }

       }

    private void OnCollisionEnter2D(Collision2D collision)
       {
          if(collision.transform.tag == "Enemy")
             {
                Destroy(collision.gameObject);
             }

       }
}
