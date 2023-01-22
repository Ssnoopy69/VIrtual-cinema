using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGyro : MonoBehaviour
{
    private Gyroscope phoneGyro;
    private Quaternion correctionQuaternion;

    // Start is called before the first frame update
    private void Start()
    {
        phoneGyro = Input.gyro;
        phoneGyro.enabled = true;
        correctionQuaternion = Quaternion.Euler(90f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        GyroModifyCamera();
    }

    void GyroModifyCamera()
    {
        Quaternion gyroQuaternion = GyroToUnity(Input.gyro.attitude);
        // rotate coordinate system 90 degrees. Correction Quaternion has to come first
        Quaternion calculatedRotation = correctionQuaternion * gyroQuaternion;
        transform.rotation = calculatedRotation;
    }

    private static Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(-q.x, q.y, -q.z, -q.w);
    }
}
