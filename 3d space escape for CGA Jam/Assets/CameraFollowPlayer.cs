using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject playerObject;
    private Vector3 offset;
    public float cameraOffset;
    // Use this for initialization
    void Start()
    {
        offset = transform.position - playerObject.transform.position;
        cameraOffset = 15f;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //float newX = (playerObject.transform.position.x + offset.x) - cameraOffset;
        transform.position = new Vector3(playerObject.transform.position.x + cameraOffset, transform.position.y, transform.position.z);
    }
}
