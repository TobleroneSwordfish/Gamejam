using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ZeroesPassDoor : PassDoor {
    protected override string StringParser(string input)
    {
        return input.Replace('o', '0');
    }
}
