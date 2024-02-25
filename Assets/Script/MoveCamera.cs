using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [Header("Keys")]
    public string ChangeCameraKey;
    public string SprintKey;
    public string JumpKey;

    [Header("Camera Transform")]
    public Transform staticCamera;
    public Transform movingCamera;
    private int cameraStateNumber;

    [Header("Player")]
    public Rigidbody rb;
    public GameObject player;
    public Transform playerTransform;
    public GameObject meshRenderer;
    public GameObject battery;
    public Vector3 defaultPos;

    [Header("Jump")]
    public float jumpForce;
    public bool grounded;
    public LayerMask groundLayer;

    [Header("Speed")]
    public float speed;
    public float maxSpeed;
    private float origSpeed;

    public float sprintSpeed;
    public float accelerationMultiplier;
    public float jumpSpeedMultiplier;

    [Header("Axis")]
    public float horizontalAxis;
    public float verticalAxis;

    public float yRotation;
    public float xRotation;

    private float yMouse;
    private float xMouse;

    [Header("Turret")]
    public GameObject controlledTurret;
    public bool controllingTurret;

    [Header("UI")]
    public GameObject canvas;
    public bool upgradeMenuActive, isPaused;

    public bool isWalking;

    [Header("States")]
    public cameraState state;

    public enum cameraState
    {
        walking,
        sprinting,
        air,
        staticMove,
        controllingTurret
    }

    // Start is called before the first frame update
    void Start()
    {
        state = cameraState.staticMove;
        cameraStateNumber = 0;
        player.GetComponent<Renderer>().enabled = false;
        rb.useGravity = false;

        origSpeed = maxSpeed;

        ChangeCameraKey = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().changeCameraKey;
        SprintKey = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().sprintKey;
        JumpKey = GameObject.FindGameObjectWithTag("DontDestroyOnLoad").GetComponent<SettingScript>().jumpKey;
    }

    // Update is called once per frame
    void Update()
    {
        //CHCEK IF PLAYER IS CHANGING CAMERA
        if (Input.GetKeyUp(ChangeCameraKey))
        {
            if (cameraStateNumber == 0)
            {
                state = cameraState.walking;

                player.GetComponent<MeshRenderer>().enabled = true;
                rb.useGravity = true;

                transform.position = movingCamera.transform.position;
                transform.rotation = movingCamera.transform.rotation;

                transform.parent = playerTransform;

                rb.drag = 2;

                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;

                cameraStateNumber = 1;

                isWalking = true;
            }
            else
            {
                state = cameraState.staticMove;

                player.GetComponent<MeshRenderer>().enabled = false;

                transform.position = staticCamera.transform.position;
                transform.rotation = staticCamera.transform.rotation;

                transform.parent = null;

                rb.drag = 0;

                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;

                cameraStateNumber = 0;

                isWalking = false;
            }
        }

        if (controllingTurret)
        {
            ControllingTurretVoid();
        }
        
        CameraState();

        if (player.transform.position.y <= -20)
        {
            RestartPlayerPos();
        }
    }

    public void FixedUpdate()
    {
        //MOVE
        if (state == cameraState.sprinting || state == cameraState.walking)
        {
            Move();
        }
    }

    public void CameraState()
    {
        //CHECK IF UPGRADE/BUILD MENU IS ACTIVE
        if (canvas.GetComponent<CanvasScript>().upgradeMenu.activeSelf == true)
        {
            upgradeMenuActive = true;
        }
        else
        {
            upgradeMenuActive = false;
        }

        //LOCK/UNLOCK CURSOR
        if (upgradeMenuActive && state != cameraState.staticMove)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (!upgradeMenuActive && state != cameraState.staticMove)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else if (state == cameraState.staticMove)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //CHECK CAMERA STATE
        if (state == cameraState.staticMove)
        {
            transform.position = staticCamera.transform.position;
            transform.rotation = staticCamera.transform.rotation;
        }
        else if (state == cameraState.sprinting)
        {
            maxSpeed = sprintSpeed;
            rb.drag = 2;

            GetInput();
            CalculateRotationAndRotate();
        }
        else if (state == cameraState.walking)
        {
            maxSpeed = origSpeed;
            rb.drag = 2;

            GetInput();
            CalculateRotationAndRotate();
        }
        else if (state == cameraState.air)
        {
            maxSpeed = origSpeed;
            rb.drag = 0;

            GetInput();
            CalculateRotationAndRotate(); 
        }
    }

    public void GetInput()
    {
        //GET AXIS
        horizontalAxis = Input.GetAxis("Horizontal");
        verticalAxis = Input.GetAxis("Vertical");

        yMouse = Input.GetAxis("Mouse X");
        xMouse = Input.GetAxis("Mouse Y");

        //CHECK IF SPRINTING
        if (Input.GetKeyDown(SprintKey))
        {
            state = cameraState.sprinting;
        }
        else if (Input.GetKeyUp(SprintKey))
        {
            state = cameraState.walking;
        }

        //CHECK IF GROUNDED
        grounded = Physics.Raycast(transform.position, Vector3.down, player.transform.localScale.y + 0.75f, groundLayer);

        //JUMP
        if (Input.GetKeyDown(JumpKey) && grounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            rb.AddForce(transform.forward * jumpForce / 2 * verticalAxis * jumpSpeedMultiplier);
            rb.AddForce(transform.right * jumpForce / 2 * horizontalAxis * jumpSpeedMultiplier);
        }

        //Reset Player Pos
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartPlayerPos();
        }

        //Show/Hide Camera
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (battery.activeSelf == true)
            {
                battery.SetActive(false);
            }
            else if (battery.activeSelf == false)
            {
                battery.SetActive(true);
            }
        }
    }

    public void CalculateRotationAndRotate()
    {
        if (!upgradeMenuActive && !isPaused && !controllingTurret)
        {
            //CALUCLATE ROTATION
            yRotation = yRotation + yMouse;
            xRotation = xRotation + xMouse;

            //ROTATE PLAYER AND CAMERA
            transform.rotation = Quaternion.Euler(-xRotation, yRotation, transform.rotation.z);
            battery.transform.rotation = Quaternion.Euler(-xRotation, yRotation, transform.rotation.z);
            player.transform.rotation = Quaternion.Euler(transform.rotation.x, yRotation, transform.rotation.z);
        }
    }

    public void ControllingTurretVoid()
    {
        transform.position = controlledTurret.GetComponent<TurretScript>().cameraPoint.transform.position;
        transform.rotation = controlledTurret.GetComponent<TurretScript>().cameraPoint.transform.rotation;

        state = cameraState.controllingTurret;

        player.GetComponent<Renderer>().enabled = false;
    }

    public void Move()
    {
        //CALCULATE SPEED
        speed = rb.velocity.magnitude * 3.6f;

        //ADD SPEED
        if (speed <= maxSpeed)
        {
            rb.AddForce(transform.forward * maxSpeed * verticalAxis * accelerationMultiplier);
            rb.AddForce(transform.right * maxSpeed * horizontalAxis * accelerationMultiplier);
        }
    }

    public void ChangeState()
    {
        state = cameraState.staticMove;
    }

    public void RestartPlayerPos()
    {
        player.transform.position = defaultPos;
    }
}