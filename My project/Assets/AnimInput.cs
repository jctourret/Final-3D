using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimInput : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            animator.Play("Rogar");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            animator.Play("Dab");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            animator.Play("Grulla");
        }
    }
}
