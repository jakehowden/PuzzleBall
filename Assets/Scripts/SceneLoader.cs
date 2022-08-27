using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public static class SceneLoader
    {
        public static void Load(Scene scene)
        {
            SceneManager.LoadScene((int)scene);
        }
    }
}