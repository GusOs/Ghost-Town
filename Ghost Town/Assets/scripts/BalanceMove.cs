using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalanceMove : MonoBehaviour
{
    bool enter = false;

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Main function
    void Update()
    {
        if(enter)
        {
            anim.SetBool("animationChair", true);
        }
    }

    // Activate the Main function when Player enter the trigger area
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enter = true;
        }
    }
}
