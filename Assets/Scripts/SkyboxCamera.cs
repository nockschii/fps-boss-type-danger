﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxCamera : MonoBehaviour
{
    [SerializeField] private Transform playerCamera;
    [SerializeField] private float skyboxScale;

	// Update is called once per frame
	void Update ()
    {
        transform.rotation = playerCamera.rotation;
        transform.localPosition = playerCamera.localPosition / skyboxScale;
    }
}
