using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Mover))]
public class PlayerController : MonoBehaviour
{
    private Mover mover;
    private SpriteRenderer spriteRenderer;

    public float movementSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        mover = GetComponent<Mover>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (!Mathf.Approximately(0, movement))
        {
            transform.rotation = movement > 0 ? Quaternion.Euler(0, -180, 0) : Quaternion.identity;
        }

        ////Moving Left
        //if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        //{
        //    mover.AccelerateInDirection(new Vector2(-1, 0));
        //    spriteRenderer.flipX = true;
        //}

        ////Moving Right
        //if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        //{
        //    mover.AccelerateInDirection(new Vector2(1, 0));
        //    spriteRenderer.flipX = false;
        //}

    }
}