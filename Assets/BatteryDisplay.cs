using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TextMesh))]
public class BatteryDisplay : MonoBehaviour {
    private TextMesh text;
    private void Start()
    {
        text = GetComponent<TextMesh>();
    }
    private void Update()
    {
        text.text = SystemInfo.batteryLevel * 100 + "%";
    }
}
