using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensY = 2f;
    public float sensX = 2f;
    public Transform ortasyon;

    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
    private void Update()
    {
        CamMovement();
    }

    public void CamMovement()
    {
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY;
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX;

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90, 90);
        transform.localEulerAngles = Vector3.right * yRotation;

        ortasyon.Rotate(Vector3.up * mouseX);
    }
}
