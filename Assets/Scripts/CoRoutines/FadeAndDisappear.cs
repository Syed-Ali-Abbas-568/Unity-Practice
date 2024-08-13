using UnityEngine;
using System.Collections;

namespace CoRoutines
{
    public static class FadeAndDisappear
    {
        public static IEnumerator ShrinkAndDisappear(GameObject objToShrink)
        {
            if (objToShrink != null)
            {

                float duration = 1.0f; // Duration in seconds for the shrink effect
                Vector3 originalScale = objToShrink.transform.localScale; // Store the original scale

                for (float t = 0; t < 1.0f; t += Time.deltaTime / duration)
                {
                    // Linearly interpolate from current scale to zero
                    objToShrink.transform.localScale = Vector3.Lerp(originalScale, Vector3.zero, t);
                    yield return null;
                }

                // Ensure the scale is set to zero at the end of the animation
                objToShrink.transform.localScale = Vector3.zero;

                // Optionally deactivate the object after shrinking
                objToShrink.SetActive(false);
            }
        }

    }

}
