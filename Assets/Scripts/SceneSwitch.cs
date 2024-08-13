using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{



    // [SerializeField] private GameObject _startSceneTrans;
    // [SerializeField] private GameObject _endSceneTrans;
    public void scene_changer(string scene_name)
    {
        if (scene_name == "TitleScreen")
        {
            GameObject[] allObjects = GameObject.FindObjectsByType<GameObject>(FindObjectsSortMode.None);
            foreach (GameObject obj in allObjects)
            {
                if (obj.tag == "planet")
                {
                    if (obj != null)
                    {
                        Destroy(obj);
                    }
                }
            }

        }


    SceneManager.LoadScene(scene_name);

        // _startSceneTrans.SetActive(true);
        // WaitForSeconds(5f);
        // //  FunctionTimer.Create(DisableStartSceneTransition, timer:5f);
        // DisableStartSceneTransition();


        // _endSceneTrans.SetActive(true);
        // FunctionTimer.Create(LoadNextLevel, timer: 1.5f);
        // SceneManager.LoadScene(scene_name);

    }

    // private static void LoadNextLevel(){
    //     SceneManager.LoadScene(scene_name);
        
    // }

    // private void DisableStartSceneTransition()
    // {

    //     _startSceneTrans.SetActive(false);

    // }

}
