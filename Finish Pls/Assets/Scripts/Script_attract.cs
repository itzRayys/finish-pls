using UnityEngine;

public class Script_attract : MonoBehaviour
{
    Rigidbody2D rb;

    bool hasTarget;
    Vector3 targetPos;
    float moveSpeed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (hasTarget)
        {
            Vector2 targetDirection = (targetPos - transform.position).normalized;
            rb.velocity = new Vector2(targetDirection.x, targetDirection.y) * moveSpeed;
        }
    }

    public void setTarget(Vector3 position)
    {
        targetPos = position;
        hasTarget = true;
    }

}
