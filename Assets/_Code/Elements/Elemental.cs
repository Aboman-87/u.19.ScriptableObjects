﻿// $ 0.0000.0000.0000x11180
/**
*   Brickhaus.Funda[mentals] v0.1.0 - 'Assettes' BRICK!@#$ HAUS ltd
*       shoulders of giants...with names:
*                                         Ryan Hipple, (Phd. HasBFD) */
using UnityEngine;
using UnityEngine.UI;

namespace Brickhaus.Fundam
{
    public class Elemental : MonoBehaviour
    {
        [Tooltip("Element represented by this elemental.")]
        public AttackElement Element;

        [Tooltip("Text to fill in with the element name.")]
        public Text Label;

        private void OnEnable()
        {
            if(Label != null)
                Label.text = Element.name;
        }

        private void OnTriggerEnter(Collider other)
        {
            Elemental e = other.gameObject.GetComponent<Elemental>();
            if (e != null)
            {
                if (e.Element.DefeatedElements.Contains(Element))
                    Destroy(gameObject);
            }
        }
    }
}