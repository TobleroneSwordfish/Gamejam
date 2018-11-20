using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.Events;
public class PassDoor : Door
{
    public GameObject ui;
    public FirstPersonController controller;
    public InputField field;
    public bool caseSensitive = true;
    protected bool uiOpen = false;
    public string password;
    private bool reEnableController = false;
    private void Start()
    {
        onSubmit += ValidateInput;
        field.onEndEdit.AddListener(onSubmit);
    }
    private UnityAction<string> onSubmit;
    public override void OnMouseDown()
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
        if (reEnableController)
        {
            controller.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && uiOpen)
        {
            CloseUI();
        }
    }
    private void CloseUI()
    {
        ui.SetActive(false);
        //reEnableController = true;
        controller.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        uiOpen = false;
    }
    private void ValidateInput(string input)
    {
        CloseUI();
        if (string.Compare(StringParser(input), password, !caseSensitive) == 0)
        {
            OpenDoor();
        }
    }
    protected virtual string StringParser(string input)
    {
        return input;
    }
}
