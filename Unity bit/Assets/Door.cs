using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
public class Door : MonoBehaviour
{
    public GameObject input;
    public FirstPersonController controller;

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            input.SetActive(true);
            controller.enabled = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            input.SetActive(false);
            controller.enabled = true;
        }
    }
}
