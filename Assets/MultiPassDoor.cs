using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;
using UnityEngine.Events;
public class MultiPassDoor : PassDoor
{
    protected override string StringParser(string input)
    {
        if (input == "aXQncyBhIHNlY3JldA==" || input == "aXRzIGEgc2VjcmV0" || input == "SXQncyBhIHNlY3JldA" || input == "SXRzIGEgc2VjcmV0" || input == "SXQncyBBIFNlY3JldA==" || input == "SXRzIEEgU2VjcmV0")
            input = "aXQncyBhIHNlY3JldA==";
        return input;
    }
}
