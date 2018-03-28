using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovementController : MonoBehaviour {

    private float m_Movement = 0f;
    private float m_Rotation = 0f;
    private float m_MoveSpeed = 1f;
    private float m_RotationSpeed = 200f;//100f;

    private const float MAX_X = 9f;
    private const float MAX_Z = 9f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_Movement = 0f;
        m_Rotation = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Movement = 1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Movement = -1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rotation = -1f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rotation = 1f;
        }

        transform.localPosition += m_MoveSpeed * m_Movement * transform.forward * Time.deltaTime;
        transform.Rotate(Vector3.up, m_Rotation * m_RotationSpeed * Time.deltaTime);

        var x = Mathf.Clamp(transform.position.x, -MAX_X, MAX_X);
        var z = Mathf.Clamp(transform.position.z, -MAX_Z, MAX_Z);
        transform.position = new Vector3(x, transform.position.y, z);
    }

    public void SetMovespeed(float movespeed)
    {
        m_MoveSpeed = movespeed;
    }
}
