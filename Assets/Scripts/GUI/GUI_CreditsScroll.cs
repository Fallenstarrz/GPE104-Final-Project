﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_CreditsScroll : MonoBehaviour
{
    public float speed;

	// Update is called once per frame
	void Update ()
    {
        transform.Translate(0,speed * Time.deltaTime,0);
	}
}
