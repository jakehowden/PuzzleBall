using UnityEngine;
using Assets.Scripts;

public class MonoSceneLoader : MonoBehaviour
{
    public void Load(int sceneBuildIndex)
    {
        SceneLoader.Load((Scene)sceneBuildIndex);
    }
}