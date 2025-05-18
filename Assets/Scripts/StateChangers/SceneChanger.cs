using UnityEngine;
using UnityEngine.SceneManagement;
using Resources;


namespace StateChangers
{
    public class SceneChanger : IStateChanger
    {
        public void ChangeSceneByName(SceneName name)
        {
            if (name == SceneName.Exit)
            {
                ExitGame();
            }
            else
            {
                SceneManager.LoadScene(name.ToString());
            }
        }
        private void ExitGame()
        {
            Application.Quit();
        }
    }
}
