using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    int timeCounter = 120;
    public Text TimeToShow;

    void Start()
    {
        StartCoroutine(waitTimer());
    }

    IEnumerator waitTimer()
    {
        for (int i = 0; i < 120; i++)
        {
            yield return new WaitForSeconds(1f);
            
            timeCounter--;
            int min = timeCounter / 60;
            int sec = timeCounter % 60;
            print("Mint" + min);
            print("Sec" + sec);

            TimeToShow.text = "Timer " + min + " : " + sec;
            if (i == 119)
            {
                print("End Timer");
            }
        }


    }

    



}