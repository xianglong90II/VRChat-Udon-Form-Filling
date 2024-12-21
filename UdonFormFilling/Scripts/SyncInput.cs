
using TMPro;
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SyncInput : UdonSharpBehaviour
{
    public TMP_InputField targetInputField;
    public void OnTriggered(){
        Networking.SetOwner(Networking.LocalPlayer,this.gameObject);
        RequestSerialization();
        SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All,nameof(syncText));
    }
    public void syncText(){
        targetInputField.text = targetInputField.text;
    }
    public override void OnDeserialization(){
        syncText();
    }
}
