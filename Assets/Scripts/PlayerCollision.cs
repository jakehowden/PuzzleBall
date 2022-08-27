using UnityEngine;
using Assets.Scripts;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagConstants.Player))
        {
            SceneLoader.Load(Scene.MainMenu);
        }
    }
}