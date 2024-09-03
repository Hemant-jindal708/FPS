using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float MoveSpeed = 15f;
    private Controls controls;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private Rigidbody rb;
    private Vector2 move = Vector2.zero;
    private float maxX = 4.49f;
    private float minX = -4.49f;

    void Awake()
    {
        controls = new Controls();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(0f, 0f, 1f);
        movement.Normalize();
        Vector3 playerpos = transform.position;
        rb.velocity = new Vector3(0, 0, movement.z * moveSpeed);
        if (move != Vector2.zero)
        {
            OnHold(ref playerpos, minX, maxX);
        }
    }
    private void RestrictMovement(ref Vector3 playerpos, float minX, float maxX)
    {
        playerpos.x = Mathf.Clamp(playerpos.x, minX, maxX);
    }
    public void OnMove(InputValue input1)
    {
        move = input1.Get<Vector2>() * MoveSpeed;
    }
    public void OnTouch(InputValue input1)
    {
        move = input1.Get<Vector2>();
        move.x = move.x *.6f;
    }
    private void OnHold(ref Vector3 playerpos, float minX, float maxX)
    {
        float x=move.x;
        playerpos += new Vector3(x * Time.deltaTime, 0, 0);
        RestrictMovement(ref playerpos, minX, maxX);
        transform.position = playerpos;
    }
}