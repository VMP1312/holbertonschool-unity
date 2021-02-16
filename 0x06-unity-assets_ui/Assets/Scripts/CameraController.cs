using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseMove = 4f;
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        if(PlayerPrefs.GetInt("isInverted") == 1)
        {
            if(Input.GetMouseButton(1))
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseMove, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * mouseMove, Vector3.left) * offset;
                transform.position = player.transform.position + offset; 
                transform.LookAt(player.transform.position);
            }
            else
                transform.position = player.transform.position + offset; 
        }
        else
        {
            if(Input.GetMouseButton(1))
            {
                offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * mouseMove, Vector3.up) * Quaternion.AngleAxis((Input.GetAxis("Mouse Y") * -1) * mouseMove, Vector3.left) * offset;
                transform.position = player.transform.position + offset; 
                transform.LookAt(player.transform.position);
            }
            else
                transform.position = player.transform.position + offset;
        }
    }
}
