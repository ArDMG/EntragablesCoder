using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
     
    private float initialSpeed = 0f;
    public Vector3 scale;
    public Vector3 position;
    private int life = 1;
    public float Speed;
    public int Damage;
    



    // Start is called before the first frame update
    void Start()
    { 
      

    }
    // Update is called once per frame
    void Update()
        {
         Debug.Log("Bullet Move");
         transform.position += new Vector3(0f, 0f, 0.01f) * Speed;
        }
    void MoveBullet()
    {
        //Move
        Debug.Log("Bullet Start");
        transform.localScale = scale;
        transform.position = position;
        initialSpeed = Speed;
    }
    void bulletDamage()
    {
        //-Life
        life = life - Damage;
        Debug.Assert(life > 0);
        //Debug.Log("Ship Lifes Reduced: " + damageLife);
        //Debug.Log("Ship Total Lifes: " + life);
    }
}

