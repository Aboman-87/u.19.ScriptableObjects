// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;
using UnityEngine.Events;

namespace RoboRyanTron.Unite2017.Variables
{
    public class UnitHealth : MonoBehaviour
    {
        public FloatVariable HP;

        public bool ResetHP;
        public FloatReference StartingHP;
        public UnityEvent DamageEvent;
        public UnityEvent DeathEvent;

        private void Start()
        {
            if (ResetHP)
                HP.SetValue(StartingHP);
        }

        private void OnTriggerEnter(Collider other)
        {
            DamageDealer damage = other.gameObject.GetComponent<DamageDealer>();
            if (damage != null)
            {
                HP.ApplyChange(-damage.DamageAmount);
                DamageEvent.Invoke();
            }

            if (HP.Value <= 0.0f)
            {
                DeathEvent.Invoke();
            }
        }
    }
}