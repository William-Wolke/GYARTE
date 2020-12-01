using System.Threading;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        private string totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(1==1) //det ska stå om man vunnit här.
        {
            Data spelData = new Data();
            //totalTime = Time.time;
            

        }
    }
}
