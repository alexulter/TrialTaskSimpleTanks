using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFireController : MonoBehaviour {

    public FireProjectile ProjectilePref;
    private List<FireProjectile> m_ProjectileBuffer = new List<FireProjectile>();
    private const int BUFFER_SIZE = 10;
    private float m_ProjectileSpeed = 10f;
    private float m_RawDamage;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < BUFFER_SIZE; i++)
        {
            m_ProjectileBuffer.Add(Instantiate<FireProjectile>(ProjectilePref));
        }
	}

    public void SetDamage(float damage)
    {
        m_RawDamage = damage;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            foreach (var entry in m_ProjectileBuffer)
            {
                if (!entry.gameObject.activeSelf)
                {
                    entry.ShootMe(transform.forward, m_ProjectileSpeed, transform.position + transform.forward * 1f, m_RawDamage);
                    break;
                }
            }
        }
	}
}
