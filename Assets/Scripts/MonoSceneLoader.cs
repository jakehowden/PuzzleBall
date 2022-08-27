using Assets.Scripts;
using UnityEngine;

public class MonoSceneLoader : MonoBehaviour
{
    public void Load(int sceneBuildIndex)
    {
        SceneLoader.Load((Scene)sceneBuildIndex);
    }
}
