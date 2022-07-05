using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimTurret : MonoBehaviour
{
    public float turretRotationSpeed = 150;
    public float offset;

    public void Aim(Vector2 inputPointerPosition)
    {
        var turretDirection = (Vector3)inputPointerPosition - transform.position;

        var desiredAngle = Mathf.Atan2(turretDirection.y, turretDirection.x) * Mathf.Rad2Deg;

        var rotationStep = turretRotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, desiredAngle-offset), rotationStep);
    }
    public void AimJoystick(Vector2 inputDirection)
    {
        var rotationStep = turretRotationSpeed * Time.deltaTime;
        float angle = Vector2.SignedAngle(inputDirection, Vector2.up);
        Debug.DrawLine(transform.position,transform.position + (Vector3)inputDirection, Color.white,0.1f);
        //float angle = Vector2.SignedAngle(transform.up,inputDirection);
        Debug.Log(angle);
        if (angle >= 0.1f || angle <= -0.1f) transform.rotation =  Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, angle),rotationStep);
            
    }
}
