using System.Collections;
using UnityEngine;

public class Camera_Follow : MonoBehaviour
{
    public Transform Player;
    public float cameraDistance = 30.0f;

    void Awake()
    {
        GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

    void FixedUpdate()
    {
        transform.position = new Vector3(Player.position.x, transform.position.y, transform.position.z);
    }
}
