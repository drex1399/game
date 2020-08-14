using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playercontroller : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator anim;

    public Transform groundpoint;

    public LayerMask groundlayer;

    public bool grounded;

    void Start()

