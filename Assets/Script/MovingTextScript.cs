using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MovingTextScript : MonoBehaviour
{
    [Header("Basic Stats")]
    public float Speed;

    public Color alphaColor;

    // Start is called before the first frame update
    void Start()
    {
        //SET STARTING COLOUR
        alphaColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        //CHANGE VARIABLES
        Speed -= 0.003f;

        alphaColor.a -= 0.005f;

        //CHANGE COLOUR 
        GetComponentInChildren<TextMeshProUGUI>().color = alphaColor;

        //MOVE
        transform.position = new Vector2(transform.position.x, transform.position.y - Speed);

        //CHCEK IF CAN DESTROY
        if (alphaColor.a < 0f)
        {
            Destroy(gameObject);
        }
    }
}