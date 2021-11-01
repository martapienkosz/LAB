using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Area1Controller : XRSceneController
{
    public Transform xrRigOrgin2;
    public XRSocketInteractor keyCardSocket;
    public XRBaseInteractable keyCard;
    public override void InIt()
    {
        if(PlayerManager.Instance.hasVisitedArea2)
        {
            keyCardSocket.startingSelectedInteractable = keyCard;
        }
        
    }

    public override Transform GetXRRigOrgin()
    {
        return PlayerManager.Instance.hasVisitedArea2 ? xrRigOrgin2 : xrRigOrigin;
    }
}
