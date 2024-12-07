using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotBreak : MonoBehaviour
{
    private Animator m_Animator;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            m_Animator.Play("Pot_Break");
        }
    }
}
