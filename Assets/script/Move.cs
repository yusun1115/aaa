using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Animator animator;
    [SerializeField] float horizonalInput;
        // Update is called once per frame
        void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector3 movement =
                new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
            transform.Translate(movement);
        if (horizontalInput > 0)
        {
            animator.SetBool("Run", true);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (horizontalInput < 0)
        {
            animator.SetBool("Run", true);
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Mathf.Abs(horizontalInput) < 1)
        {
            animator.SetBool("Run", false);
        }


       
    }
    
}
