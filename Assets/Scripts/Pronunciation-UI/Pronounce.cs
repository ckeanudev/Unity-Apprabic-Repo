using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Pronounce : MonoBehaviour
{
    PronouneUIScript pronouneUIScript;
    public GameObject PronouneUIS;

    public GameObject firstPage;
    public GameObject secondPage;

    public AudioSource origAudio;

    public AudioSource firstAudio;
    public AudioSource secondAudio;
    public AudioSource thirdAudio;

    public GameObject audioContainer1;
    public GameObject audioContainer2;
    public GameObject audioContainer3;

    public GameObject choiceContainer1;
    public GameObject choiceContainer2;
    public GameObject choiceContainer3;

    void OnEnable()
    {
        int num = Random.Range(1, 4);

        pronouneUIScript = PronouneUIS.GetComponent<PronouneUIScript>();

        audioContainer1.SetActive(false);
        audioContainer2.SetActive(false);
        audioContainer3.SetActive(false);

        choiceContainer1.SetActive(false);
        choiceContainer2.SetActive(false);
        choiceContainer3.SetActive(false);

        if(num == 1)
        {
            audioContainer1.SetActive(true);
            choiceContainer1.SetActive(true);
        }
        else if (num == 2)
        {
            audioContainer2.SetActive(true);
            choiceContainer2.SetActive(true);
        }
        else if (num == 3)
        {
            audioContainer3.SetActive(true);
            choiceContainer3.SetActive(true);
        }

        firstPage.SetActive(true);
        secondPage.SetActive(false);
    }

    public void NextPage()
    {
        firstPage.SetActive(false);
        secondPage.SetActive(true);
    }

    public void OrigAudio()
    {
        origAudio.Play();
    }

    public void PlayAudio(int audio)
    {
        if (audio == 1)
        {
            firstAudio.Play();
        }
        else if (audio == 2)
        {
            secondAudio.Play();
        }
        else if (audio == 3)
        {
            thirdAudio.Play();
        }
    }

    public void OptionButtons(int num)
    {
        if(num == 1)
        {
            Debug.Log("NICE NICE NICE");
            pronouneUIScript.showWinDialog = true;
            pronouneUIScript.delayOnce = true;
            pronouneUIScript.userAnswer = true;
        }
        else
        {
            Debug.Log("NICE NICE NICE");
            pronouneUIScript.showWinDialog = true;
            pronouneUIScript.delayOnce = true;
            pronouneUIScript.userAnswer = false;
        }
    } 




}
