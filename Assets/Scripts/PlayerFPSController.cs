using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[RequireComponent(typeof(CharacterMovement))]
[RequireComponent(typeof(MouseLook))]
public class PlayerFPSController : MonoBehaviour
{

    //public GameObject cam;
    //public float walkSpeed = 5f;
    //public float hRotationSpeed = 100f;
    //public float vRotationSpeed = 80f;

    private CharacterMovement characterMovement;
    private MouseLook mouseLook;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        //GameObject.Find("Player").gameObject.SetActive(false);

        characterMovement = GetComponent<CharacterMovement>();
        mouseLook = GetComponent<MouseLook>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Rotation();
    }

    private void Movement()
    {
        float hMovementInput = Input.GetAxisRaw("Horizontal");
        float vMovementInput = Input.GetAxisRaw("Vertical");

        bool jumpInput = Input.GetButtonDown("Jump");
        bool dashInput = Input.GetButton("Dash");

        characterMovement.moveCharacter(hMovementInput, vMovementInput, jumpInput, dashInput);
    }

    private void Rotation()
    {
        float hRotationInput = Input.GetAxis("Mouse X");
        float vRotationInput = Input.GetAxis("Mouse Y");

        mouseLook.handleRotation(hRotationInput, vRotationInput);

    }
}
