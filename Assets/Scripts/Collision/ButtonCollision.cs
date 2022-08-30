using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCollision : MonoBehaviour
{
    public GameObject Door;
    private ParticleSystem ParticleSystem;
    private Animator Animator;
    private BoxCollider BoxCollider;

    private void Start()
    {
        Animator = GetComponent<Animator>();
        BoxCollider = GetComponent<BoxCollider>();
        ParticleSystem = Door.GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagConstants.Player))
        {
            BoxCollider.enabled = false;
            Animator.enabled = true;

            ParticleSystem.Play();
            Destroy(Door, 2f);
        }
    }
}