using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WinPanelScript : MonoBehaviour
{
    public TextMeshProUGUI winText;

    public string winType;

    WritingUIScript writingUIScript;
    public GameObject writingUIS;

    public GameObject banner1Star;
    public GameObject banner2Star;
    public GameObject banner3Star;
    
    string[] winDialog = new string[4];

    void OnEnable()
    {
        writingUIScript = writingUIS.GetComponent<WritingUIScript>();

        int num = Random.Range(0, 4);

        if(winType == "win")
        {

            winDialog[0] = "Great Job!";
            winDialog[1] = "Well Done!";
            winDialog[2] = "Nice One!";
            winDialog[3] = "Nice Work!";

            Debug.Log(winDialog[num]);

            winText.text = winDialog[num];
        }
        else if (winType == "unwin")
        {

            winDialog[0] = "Try Again";
            winDialog[1] = "Almost";
            winDialog[2] = "Nice One!";
            winDialog[3] = "Nice Work!";

            Debug.Log("Try Again");

            winText.text = "Try Again";
        }

    }
}
