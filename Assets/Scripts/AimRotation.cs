using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    private bool facingRight = true;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = transform; // 캐릭터의 Transform 컴포넌트를 가져옵니다.
    }

    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        FlipCharacter(mousePosition);

    }

    void FlipCharacter(Vector3 targetPosition)
    {
        Vector3 direction = targetPosition - playerTransform.position;

        if (direction.x < 0 && facingRight || direction.x > 0 && !facingRight)
        {
            facingRight = !facingRight;
            Vector3 scale = playerTransform.localScale;
            scale.x *= -1;
            playerTransform.localScale = scale;
        }
    }
}
