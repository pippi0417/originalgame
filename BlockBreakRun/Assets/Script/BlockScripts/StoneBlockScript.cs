﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBlockScript : BlockScript {


    // Use this for initialization
    void Start()
    {
        blockHp = 200;
        material = "stone";
        itemId = "block_stone";
        hardend = 7;
        aptitude = "hummer";
    }
}
