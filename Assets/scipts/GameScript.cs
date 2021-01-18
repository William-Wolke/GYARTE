using System.Diagnostics;
using System.Net;
using System.Globalization;
using System.ComponentModel;
using System.Timers;
using System;
using System.Threading;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
/*using System.Xml;*
using System.Xml.Serialization;*/

public class GameScript : MonoBehaviour
{
    public int respawnTimes = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if(GoalScript.finished == true) //det ska stå om man vunnit här.
        {
            Time.timeScale = 0;

            List<string> info = new List<string>() // En list skapas där all data överförs
            {
                "Times respawn: " + Respawn.timesLost.ToString(),
                "Total playing time: " + Time.time.ToString()
            };

            File.WriteAllLines(@"data.txt", info.ToArray());// File.WriteAllLines skriver ut all data i en array
        }
        
    }
    
    
}
