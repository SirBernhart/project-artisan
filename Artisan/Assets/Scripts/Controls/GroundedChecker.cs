using UnityEngine;

class GroundedChecker : MonoBehaviour
{
    private bool isGrounded;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != this.transform.root.tag)
            isGrounded = true;
        else
            isGrounded = false;
    }

    private void OnTriggerExit(Collider other)
    {
        isGrounded = false;
    }

    public bool GetIsGrounded()
    {
        return isGrounded;
    }
}

