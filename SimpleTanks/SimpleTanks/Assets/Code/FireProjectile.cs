using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MonoBehaviour {

    private Vector3 m_Direction;
    private float m_Movespeed;
    private float m_StartTime;
    private float m_Liespawn = 2f;
    private float m_RawDaamge;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += m_Direction * m_Movespeed * Time.deltaTime;
        if (Time.timeSinceLevelLoad - m_StartTime > m_Liespawn)
        {
            StopMe();
        }
	}

    public void ShootMe(Vector3 direction, float movespeed, Vector3 startPosition, float rawDamage)
    {
        m_Direction = direction;
        m_Movespeed = movespeed;
        transform.position = startPosition;
        gameObject.SetActive(true);
        m_StartTime = Time.timeSinceLevelLoad;
    }

    public void StopMe()
    {
        gameObject.SetActive(false);
    }
}
