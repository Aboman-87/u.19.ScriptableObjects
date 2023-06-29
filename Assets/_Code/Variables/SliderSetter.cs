// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;
using UnityEngine.UI;

namespace RoboRyanTron.Unite2017.Variables
{
    [ExecuteInEditMode]
    public class SliderSetter : MonoBehaviour
    {
        public Slider Slider;
        public FloatVariable Variable;

        private void Update()
        {
            if (Slider != null && Variable != null)
                Slider.value = Variable.Value;
        }
    }
}