using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Animator animator;
    [SerializeField]
    private float moveSpeed = 2.0f;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            // 動かす
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            // アニメーション再生
            animator.SetBool("Running", true);
        } else
        {
            animator.SetBool("Running", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // 動かす
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
            // アニメーション再生
            animator.SetBool("Running", true);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
            transform.Rotate(0, -5, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
            transform.Rotate(0, 5, 0);
        }
    }
}
