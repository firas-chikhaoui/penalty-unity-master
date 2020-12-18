using System.Security.Cryptography;
using System.Timers;
using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Range(-90.0f, 90.0f)]
    public float m_Range;
    public float m_SmoothTime;
    public Vector3 m_Axis;
    private Vector3 m_Origin;
    public bool vertical;
    Vector3 lastPos;
    float val = 0f;

    private void Start()
    {
        m_Origin = transform.eulerAngles;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastPos = Input.mousePosition;
        }
        if(Input.GetMouseButton(0))
        {
            
            float dir = 0;

            Vector3 diff = Input.mousePosition - lastPos;
            lastPos = Input.mousePosition;
            if(vertical)dir = diff.y;
            else dir = diff.x;
            if(dir != 0)
            {
                val = Mathf.Clamp(val+dir*Time.deltaTime, -1f, 1f);
                
                Vector3 rotation = m_Axis * val * m_Range;
                transform.localEulerAngles = m_Origin + rotation;
                
            }
        }
    }
}
