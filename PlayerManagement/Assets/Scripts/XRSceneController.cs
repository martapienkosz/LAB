using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRSceneController : MonoBehaviour
{
    public Transform xrRigOrigin;
    public virtual void InIt() { }

    public virtual Transform GetXRRigOrgin()
    {
        return xrRigOrigin;   
    }
}
