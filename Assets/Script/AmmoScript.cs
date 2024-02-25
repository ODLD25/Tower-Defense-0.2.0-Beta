using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoScript : MonoBehaviour
{
    [Header("Stats")]
    public float shootSpeed;
    public float speed;
    public float timer;
    public float damage;

    public Rigidbody rb;

    [Header("GameObjects")]
    public GameObject turret;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        if (enemy != null)
        {
            //CALCULATE ENEMY POSITION
            Vector3 targetEnemy = new Vector3(enemy.transform.position.x, transform.position.y, enemy.transform.position.z);
            //LOOK AT ENEMY 
            transform.LookAt(targetEnemy);
        }

        //START METHOD
        Shoot();
    }

    // Update is called once per frame
    void Update()
    {
        //CHANGE VALUES
        timer -= Time.deltaTime;

        //CHECK IF TIMER TIMED OUT
        if (timer <= 0f)
        {
            //DESTROY THIS GAMEOBJECT
            Destroy(gameObject);
        }
    }

    public void FixedUpdate()
    {
        //CALCULATE SPEED OF THIS GAMEOBJECT
        speed = rb.velocity.magnitude * 3.6f;
    }

    public void Shoot()
    {
        //ADD FORCE
        rb.AddForce(transform.forward * shootSpeed, ForceMode.Impulse);
    }
}