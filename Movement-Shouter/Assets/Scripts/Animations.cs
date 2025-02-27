using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {

        m_Animator = gameObject.GetComponent<Animator>();
    }


    void Update()
    {

        Debug.Log("!!");
        if (Input.GetKeyDown(KeyCode.V))
        {

            Debug.Log("!!!!");


            m_Animator.SetTrigger("Jump");

        }

    }
}
