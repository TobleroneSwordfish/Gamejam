using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
public class Door : MonoBehaviour
{
    public GameObject UI;
    public FirstPersonController controller;
    public InputField field;
    public bool uiOpen = false;
    // Update is called once per frame
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !uiOpen)
        {
            UI.SetActive(true);
            controller.enabled = false;
            //Cursor.lockState = CursorLockMode.Confined;
            field.ActivateInputField();
            uiOpen = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && uiOpen)
        {
            UI.SetActive(false);
            controller.enabled = true;
            //Cursor.lockState = CursorLockMode.Locked;
            uiOpen = false;
        }
    }
}
