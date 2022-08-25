using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagConstants.Player))
        {
            Debug.Log("Quitting application...");
            Application.Quit();
        }
    }
}
