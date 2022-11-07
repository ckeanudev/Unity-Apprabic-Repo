using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrange : MonoBehaviour
{
    public GameObject firstPage;
    public GameObject secondPage;

    public bool firstPosition = false;
    public bool secondPosition = false;
    public bool thirdPosition = false;
    public bool fourthPosition = false;
    public bool fifthPosition = false;

    public bool firstPosFill = false;
    public bool secondPosFill = false;
    public bool thirdPosFill = false;
    public bool fourthPosFill = false;
    public bool fifthPosFill = false;

    ArrangeUIScript arrangeUIScript;
    public GameObject arrangeUIS;

    public GameObject doneButton;

    void OnEnable()
    {
        arrangeUIScript = arrangeUIS.GetComponent<ArrangeUIScript>();

        firstPage.SetActive(true);
        secondPage.SetActive(false);

        doneButton.SetActive(true);
        StartCoroutine(ShowSecondPage());
    }

    public IEnumerator ShowSecondPage()
    {
        yield return new WaitForSeconds(3f);
        firstPage.SetActive(false);
        secondPage.SetActive(true);
    }

    public void ArrangeDoneButton()
    {
        doneButton.SetActive(false);

        if (firstPosition && secondPosition && thirdPosition && fourthPosition && fifthPosition)
        {
            Debug.Log("All Position Fixed!!");
            arrangeUIScript.showWinDialog = true;
            arrangeUIScript.delayOnce = true;
            arrangeUIScript.userAnswer = true;
        }
        else
        {
            arrangeUIScript.showWinDialog = true;
            arrangeUIScript.delayOnce = true;
            arrangeUIScript.userAnswer = false;
        }

        firstPosFill = false;
        secondPosFill = false;
        thirdPosFill = false;
        fourthPosFill = false;
        fifthPosFill = false;

        firstPosition = false;
        secondPosition = false;
        thirdPosition = false;
        fourthPosition = false;
        fifthPosition = false;
    }

}
