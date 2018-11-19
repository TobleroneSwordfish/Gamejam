using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.Events;
public class Door : MonoBehaviour
{
    public GameObject ui;
    public FirstPersonController controller;
    public InputField field;
    public Text successText;
    public bool uiOpen = false;
    public string password;
    private void Start()
    {
        onSubmit += ValidateInput;
        field.onEndEdit.AddListener(onSubmit);
    }
    private UnityAction<string> onSubmit;
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && !uiOpen)
        {
            controller.enabled = false;
            ui.SetActive(true);
            field.Select();
            field.ActivateInputField();
            uiOpen = true;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && uiOpen)
        {
            CloseUI();
        }
    }
    private void CloseUI()
    {
        ui.SetActive(false);
        controller.enabled = true;
        //Cursor.lockState = CursorLockMode.Locked;
        uiOpen = false;
    }
    private void ValidateInput(string input)
    {
        CloseUI();
        if (input == password)
        {
            gameObject.SetActive(false);
        }
    }
}
