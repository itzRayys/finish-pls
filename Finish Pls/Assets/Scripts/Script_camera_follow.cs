using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_camera_follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    void FixedUpdate()
    {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y +
            offset.y, target.position.z + offset.z);
    }

    public void cameraZoomIn()
    {
        if (Camera.main.orthographicSize > 4f)
        {
            Camera.main.orthographicSize = Camera.main.orthographicSize -= 1f;
        }
    }
    public void cameraZoomOut()
    {
        if (Camera.main.orthographicSize < 16f)
        {
            Camera.main.orthographicSize = Camera.main.orthographicSize += 1f;
        }
    }
}
