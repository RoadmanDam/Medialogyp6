using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class OvrAvatarHand : MonoBehaviour
{

    public void UpdatePose(OvrAvatarDriver.ControllerPose pose)
    {
        if (GetComponent<Rigidbody>() != null)
        {
            GetComponent<Rigidbody>().detectCollisions = pose.handTrigger >= 0.75f;
        }
    }
}
