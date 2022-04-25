using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace OOP
{
    public class RadarObj : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] private Image _ico;

        private void OnValidate()
        {
            _ico = Resources.Load<Image>("RadarTargetImage");
        }

        private void OnDisable()
        {
            if(gameObject!=null)
            Radar.RemoveObjectFromRadar(gameObject);
        }

        private void OnEnable()
        {
            if (gameObject != null)
                Radar.AddObjectToRadar(gameObject, _ico);
        }
    }
}
