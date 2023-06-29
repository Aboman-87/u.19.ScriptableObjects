// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;

namespace RoboRyanTron.Unite2017.Variables
{
    public class VariableAudioTrigger : MonoBehaviour
    {
        public AudioSource AudioSource;

        public FloatVariable Variable;

        public FloatReference LowThreshold;

        private void Update()
        {
            if (Variable.Value < LowThreshold)
            {
                if (!AudioSource.isPlaying)
                    AudioSource.Play();
            }
            else
            {
                if (AudioSource.isPlaying)
                    AudioSource.Stop();
            }
        }
    }
}