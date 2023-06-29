// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;
using UnityEngine.UI;

namespace Brickhaus.Fundam
{
    public class ThingMonitor : MonoBehaviour
    {
        public ThingRuntimeSet Set;

        public Text Text;

        private int previousCount = -1;

        private void OnEnable()
        {
            UpdateText();
        }

        private void Update()
        {
            if (previousCount != Set.Items.Count)
            {
                UpdateText();
                previousCount = Set.Items.Count;
            }
        }

        public void UpdateText()
        {
            Text.text = "There are " + Set.Items.Count + " things.";
        }
    }
}