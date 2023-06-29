using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    public float speed =5f;
    public float jumpForce = 0.5f;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        m_Rigidbody.AddForce( 0,0,speed , ForceMode.Acceleration);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigidbody.AddForce( -speed,0,0 , ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigidbody.AddForce( speed,0,0 , ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            m_Rigidbody.AddForce( 0,jumpForce,0 , ForceMode.Impulse);
        }
    }
}
