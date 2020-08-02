using UnityEngine;

class PlayerInput : MonoBehaviour
{
    float vertical, horizontal;
    [SerializeField] Movement playerMovement;

    private void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

    }

    private void FixedUpdate()
    {
        playerMovement.Move(horizontal, vertical);
    }
}
