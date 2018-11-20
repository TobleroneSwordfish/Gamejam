using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MK.Glow;
public class Fuckup : MonoBehaviour
{
    private MKGlowFree glowScript;
    public float fuckTime;
    private void Start()
    {
        glowScript = GetComponent<MKGlowFree>();
    }
    public void DoIt()
    {
        glowScript.GlowType = GlowType.Fullscreen;
        StartCoroutine(Loop());
    }
    private IEnumerator Loop()
    {
        while(glowScript.GlowTint.b < 1)
        {
            glowScript.GlowTint = new Color(glowScript.GlowTint.r, glowScript.GlowTint.g, glowScript.GlowTint.b + Time.deltaTime * 1 / fuckTime);
            yield return null;
        }
        while (glowScript.GlowTint.g < 1)
        {
            glowScript.GlowTint = new Color(glowScript.GlowTint.r, glowScript.GlowTint.g + Time.deltaTime * 1 / fuckTime, glowScript.GlowTint.b);
            yield return null;
        }
        while (glowScript.GlowTint.r < 1)
        {
            glowScript.GlowTint = new Color(glowScript.GlowTint.r + Time.deltaTime * 1 / fuckTime, glowScript.GlowTint.g, glowScript.GlowTint.b);
            yield return null;
        }
        glowScript.GlowTint = new Color(0,0,0);
        StopIt();
    }
    public void StopIt()
    {
        glowScript.GlowType = GlowType.Selective;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            //print("keycode read");
            DoIt();
        }
    }
}
