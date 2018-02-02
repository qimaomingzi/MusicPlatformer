
using UnityEngine;
using System.Collections;

public class CameraLerpToTransform : MonoBehaviour {
    public float movingSpeed;
    public GameObject avatar;
    void Start(){
        transform.position = new Vector3(avatar.transform.position.x,avatar.transform.position.y,-10);

    }
    void FixedUpdate()
    {
        transform.position += Vector3.right * movingSpeed * Time.deltaTime;
    }
}
