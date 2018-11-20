﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reflections;
public class Reveal : MonoBehaviour, Target {
    AudioSource source;
    private void Start()
    {
        source = GetComponent<AudioSource>();
        foreach (Transform t in transform)
        {
            t.gameObject.AddComponent<Reflector>().parent = this;
        }

    }
    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            source.Play();
            GetComponent<Fuckup>().DoIt();
        }
    }
}
