using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public Animator animator;
    public CharacterController characterController;

    private Vector3 moveDirection = Vector3.zero;
    private Controls _input;
    void Awake()
    {
        //characterController = GetComponent<CharacterController>();
        _input = new Controls();
        _input.Player.Shoot.performed += context => Shoot();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }
    void Update()
    {
        Vector2 moveDirection = _input.Player.Move.ReadValue<Vector2>();
        Move(moveDirection);
    }

    private void Move(Vector2 direction)
    {
        float scaledMoveSpeed = speed * Time.deltaTime;
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y);
        transform.position += moveDirection * scaledMoveSpeed;
    }

    private void Shoot()
    {
        Debug.Log("Shoot");
    }
}