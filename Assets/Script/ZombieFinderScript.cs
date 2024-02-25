using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFinderScript : MonoBehaviour
{
    public GameObject parentTurret;
    public float minPosX;
    private int arrayPos;
    // Start is called before the first frame update
    void Start()
    {
        arrayPos = 0;
    }

    private void Update()
    {
        if (transform.transform.position.x >= minPosX)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 100);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            parentTurret.GetComponent<TurretScript>().enemies[arrayPos] = other.gameObject;
            arrayPos++;
        }
    }
}
