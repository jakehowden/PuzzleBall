using UnityEngine;
using Assets.Scripts;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(TagConstants.Player))
        {
            SceneLoader.Load(Scene.MainMenu);
        }
    }
}