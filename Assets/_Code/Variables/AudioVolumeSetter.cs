// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;
using UnityEngine.Audio;

namespace RoboRyanTron.Unite2017.Variables
{
    public class AudioVolumeSetter : MonoBehaviour
    {
        public AudioMixer Mixer;
        public string ParameterName = "";
        public FloatVariable Variable;

        private void Update()
        {
            float dB = Variable.Value > 0.0f ?
                20.0f * Mathf.Log10(Variable.Value) : 
                -80.0f;

            Mixer.SetFloat(ParameterName, dB);
        }
    }
}