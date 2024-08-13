using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace CoRoutines
{
    public static class SmoothMove
    {
        public static IEnumerator SmoothMoveCoRoutine(GameObject obj, Vector3 targetPosition, string sceneName)
        {
            float duration = 2.0f;
            Vector3 startPosition = obj.transform.position;
            float elapsedTime = 0;

            while (elapsedTime < duration)
            {
                obj.transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / duration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            //obj.transform.position = targetPosition; // Ensure final position

                SceneManager.LoadScene(sceneName);
        }
    }
}