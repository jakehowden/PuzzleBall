using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
