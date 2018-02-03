using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour {
    public float horizontalSpeed;
    public float verticalSpeed;
    public float rotationSpeed;
    public float leftBound;
    public float rightBound;
    public float upperBound;
    public float lowerBound;
    public enum MovingType
    {
        linearMove,
        rotate,
        CursiveMove,
        periodicLinearMove
    };

    public MovingType currentMoveType;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(currentMoveType == MovingType.linearMove){
            LinearMove(verticalSpeed,horizontalSpeed);
        }
	}
    void LinearMove(float vertical, float horizontal){
        transform.position = new Vector3(transform.position.x + vertical * Time.deltaTime, transform.position.y + horizontal * Time.deltaTime, transform.position.z);
    }

}
