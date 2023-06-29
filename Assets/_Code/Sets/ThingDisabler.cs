// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;

namespace Brickhaus.Fundam
{
    public class ThingDisabler : MonoBehaviour
    {
        public ThingRuntimeSet Set;

        public void DisableAll()
        {
            // Loop backwards since the list may change when disabling
            for (int i = Set.Items.Count-1; i >= 0; i--)
            {
                Set.Items[i].gameObject.SetActive(false);
            }
        }

        public void DisableRandom()
        {
            int index = Random.Range(0, Set.Items.Count);
            Set.Items[index].gameObject.SetActive(false);
        }
    }
}