using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class FadeAndCenter : MonoBehaviour
{

    private List<Coroutine> runningCoroutines = new List<Coroutine>();
    public string sceneName = "FinalScene";
    public Vector3 finalPos = new Vector3(0, 0, 5);
    private void OnMouseDown()
    {
        if (gameObject.scene.name == "Scene1")
        {
            FadeOtherObjects();
        }
    }

    void FadeOtherObjects()
    {
        GameObject[] allObjects = GameObject.FindObjectsByType<GameObject>(FindObjectsSortMode.None);
        foreach (GameObject obj in allObjects)
        {
            if (obj != this.gameObject) // Check if the object is not the clicked one
            {
                if (obj.tag == "planet")
                {
                  StartCoroutine(CoRoutines.FadeAndDisappear.ShrinkAndDisappear(obj));
                  
                }


            }
            else
            {

                DontDestroyOnLoad(obj);
                Destroy(obj.GetComponent<OrbitingScript>());
                StartCoroutine(CoRoutines.SmoothMove.SmoothMoveCoRoutine(obj, finalPos, sceneName));
                
            }
        }
    }


  


}
