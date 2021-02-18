using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Xmove;
    private float Zmove;
    private Vector3 playerInput;
    public CharacterController player;

    public float speed;
    private Vector3 movePlayer;
    public float gravity = 9.8f;
    private float fallV;
    public float jumpForce = 3;
    public  Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento del personaje
        Xmove = Input.GetAxis("Horizontal");
        Zmove = Input.GetAxis("Vertical");

        playerInput = new Vector3(Xmove, 0, Zmove);
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        
        setGravity();

        playerJump();
        
        movePlayer = movePlayer * speed;

        player.Move (movePlayer * Time.deltaTime);

        if (player.transform.position.y < -30)
            transform.position = new Vector3(0, 50, 0);
    }

    // Movimiento relativo a la camara
    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;
        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    // Gestor de gravedad
    void setGravity()
    {
        if (player.isGrounded)
        {
            fallV = -gravity * Time.deltaTime;
            movePlayer.y = fallV;
        }
        else
        {
            fallV -= gravity * Time.deltaTime;
            movePlayer.y = fallV;
        }
    }

    //Salto del personaje
    void playerJump()
    {
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallV = jumpForce;
            movePlayer.y = fallV;
        }
    }
}
