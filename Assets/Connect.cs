using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using FusedVR.Web3;

public class Connect : MonoBehaviour
{
    public string theEmail;
    public GameObject inputField;
    public GameObject textDisplay;

 

async public void Storename() {
   
    


if (await Web3Manager.Login("app is", "patrick.ortell@arus.io")){
            string balance = await Web3Manager.GetNativeBalance("eth");
           textDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Your balance is " + balance + "wei *";

        }

// theEmail = inputField.GetComponent<TMPro.TextMeshProUGUI>().text;

    // textDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "welocme" + theEmail + " to the game";
    //  Debug.Log("============>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>: " + theEmail);
}




}
