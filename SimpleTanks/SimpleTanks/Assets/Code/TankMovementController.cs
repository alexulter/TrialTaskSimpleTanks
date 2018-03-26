using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovementController : MonoBehaviour {

    private float m_Movement = 0f;
    private float m_Rotation = 0f;
    private float m_MoveSpeed = 1f;
    private float m_RotationSpeed = 100f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        m_Movement = 0f;
        m_Rotation = 0f;
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            m_Movement = 1f;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            m_Movement = -1f;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rotation = -1f;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            m_Rotation = 1f;
        }

        transform.localPosition += m_MoveSpeed * m_Movement * transform.forward * Time.deltaTime;
        transform.Rotate(Vector3.up, m_Rotation * m_RotationSpeed * Time.deltaTime);
    }

    public void SetMovespeed(float movespeed)
    {
        m_MoveSpeed = movespeed;
    }
}
