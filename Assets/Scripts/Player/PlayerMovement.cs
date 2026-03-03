using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float forwardSpeed = 5.0f;
    [SerializeField] private float horizontalSpeed = 5.0f;


    private void Update()
    {
        if (!GameStateManager.instance.IsPlaying())
        {
            return;
        }
        MoveForward();
        HortizontalMovementController();

    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
    }

    private void HortizontalMovementController()
    {
        float input = Input.GetAxis("Mouse X");
        transform.Translate(Vector3.right * input * horizontalSpeed * Time.deltaTime);
        
    }

}
