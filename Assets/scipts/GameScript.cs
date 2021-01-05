using System.Timers;
using System;
using System.Threading;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class GameScript : MonoBehaviour
{
    XmlSerializer dataSerializer = new XmlSerializer(typeof(Data));
    //private float totalTime;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 200;
        
        Debug.Log("Despacito");
    }

    // Update is called once per frame
    void Update()
    {
        if(1==1) //det ska stå om man vunnit här.
        {
            Data spelData = new Data();
            spelData.totalTime = Time.time;
            spelData.timesLost = /*respawnTimes*/0;
            
            using (FileStream file = File.Open(@"gameData.xml", FileMode.OpenOrCreate))
            {
                dataSerializer.Serialize(file, 1);
            }
        }
    }
}
