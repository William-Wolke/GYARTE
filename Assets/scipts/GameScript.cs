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
        Application.targetFrameRate = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if(1==1) //det ska stå om man vunnit här.
        {
        }
        
        Debug.Log("Ett LaGrandeVittne");
        
    }
    
    
}
