using UnityEngine;

class GroundedChecker : MonoBehaviour
{
    private bool isGrounded;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != this.transform.root.tag)
            isGrounded = true;
        else
            isGrounded = false;
    }

    public bool GetIsGrounded()
    {
        return isGrounded;
    }
}

