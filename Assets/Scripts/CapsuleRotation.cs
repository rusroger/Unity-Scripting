using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.IMGUI.Controls.PrimitiveBoundsHandle;

public class CapsuleRotation : MonoBehaviour
{

    public float rotationSpeed;
    public Vector3 rotationAxis;

    
    // Update is called once per frame
    void Update()
    {
        rotationAxis = CapsuleMovement.ClampVector3(rotationAxis);

        transform.Rotate(rotationAxis * (rotationSpeed * Time.deltaTime));

    }
}
