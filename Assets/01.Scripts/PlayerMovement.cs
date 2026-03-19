using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float speed = 4;
    public Vector2 moveDir;

    private void Update()
    {
        transform.position += (Vector3)moveDir * speed *Time.deltaTime;
    }

    public void OnMove(InputValue value)
    {
        moveDir= value.Get<Vector2>();
    }
}
