using Cainos.PixelArtTopDown_Basic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public SpriteRenderer spriteRenderer;
    private void Start()
    {

    }

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position += (new Vector3(x, y)).normalized*Time.deltaTime* speed;

        Vector3 mousePos = Input.mousePosition;

        if (mousePos.x > Screen.width / 2)
        {
            spriteRenderer.flipX = false;
        }
        else if (mousePos.x < Screen.width / 2)
        {
            spriteRenderer.flipX = true;
        }
    }
}