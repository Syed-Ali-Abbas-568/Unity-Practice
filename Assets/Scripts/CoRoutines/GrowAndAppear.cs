using UnityEngine;
using System.Collections;

namespace CoRoutines
{
    public static class GrowAndAppear
    {
        public static IEnumerator GrowAndAppearRoutine(GameObject objToGrow)
        {
            if (objToGrow != null)
            {
                float duration = 1.0f; // Duration in seconds for the grow effect
                Vector3 originalScale = new Vector3(1, 1, 1); // Store the original scale
                objToGrow.transform.localScale = Vector3.zero; // Start from zero scale

                for (float t = 0; t <= 1.0f; t += Time.deltaTime / duration)
                {
                    // Linearly interpolate from zero scale to the original scale
                    objToGrow.transform.localScale = Vector3.Lerp(Vector3.zero, originalScale, t);
                    yield return null;
                }

                // Ensure the scale is set to the original at the end of the animation
                objToGrow.transform.localScale = originalScale;
            }
        }

    }
}


