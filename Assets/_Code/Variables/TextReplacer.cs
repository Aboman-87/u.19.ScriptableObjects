// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;
using UnityEngine.UI;

namespace RoboRyanTron.Unite2017.Variables
{
    public class TextReplacer : MonoBehaviour
    {
        public Text Text;

        public StringVariable Variable;

        public bool AlwaysUpdate;
        
        private void OnEnable()
        {
            Text.text = Variable.Value;
        }

        private void Update()
        {
            if (AlwaysUpdate)
            {
                Text.text = Variable.Value;
            }
        }
    }
}