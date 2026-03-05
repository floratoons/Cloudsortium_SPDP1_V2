using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public PlayerController player;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isIdle", player.isIdle);
        anim.SetFloat("MoveX", player.moveInput);
        anim.SetBool("isFalling", player.isFalling);
        anim.SetBool("isRising", player.isRising);
        anim.SetBool("isGrounded", player.isGrounded);


    }

}
