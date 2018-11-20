﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryDoor : Door {
    public bool pluggedIn;

    private void Start()
    {
        pluggedIn = SystemInfo.batteryStatus == BatteryStatus.Charging || SystemInfo.batteryStatus == BatteryStatus.Full;
    }
    public override void OnMouseDown()
    {
        
    }
    // Update is called once per frame
    void Update () {
		bool newPluggedIn = SystemInfo.batteryStatus == BatteryStatus.Charging || SystemInfo.batteryStatus == BatteryStatus.Full;
        if (pluggedIn != newPluggedIn)
        {
            OpenDoor();
        }
        pluggedIn = newPluggedIn;
    }
}
