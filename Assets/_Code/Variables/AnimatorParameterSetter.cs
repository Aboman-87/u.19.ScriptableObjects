// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;

namespace RoboRyanTron.Unite2017.Variables
{
    /// <summary>
    /// Takes a FloatVariable and sends its value to an Animator parameter 
    /// every frame on Update.
    /// </summary>
    public class AnimatorParameterSetter : MonoBehaviour
    {
        [Tooltip("Variable to read from and send to the Animator as the specified parameter.")]
        public FloatVariable Variable;

        [Tooltip("Animator to set parameters on.")]
        public Animator Animator;

        [Tooltip("Name of the parameter to set with the value of Variable.")]
        public string ParameterName;

        /// <summary>
        /// Animator Hash of ParameterName, automatically generated.
        /// </summary>
        [SerializeField] private int parameterHash;

        private void OnValidate()
        {
            parameterHash = Animator.StringToHash(ParameterName);
        }

        private void Update()
        {
            Animator.SetFloat(parameterHash, Variable.Value);
        }
    }
}