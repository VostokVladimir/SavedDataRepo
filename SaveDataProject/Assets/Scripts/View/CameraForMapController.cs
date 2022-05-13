using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace OOP
{
    public class CameraForMapController : MonoBehaviour
    {
        public GameObject playerfolowReferense;
        public float distanceUpperPlayerForCamera=100;
        private RenderTexture referencesTextureForCamera;

        private void Start()
        {
            referencesTextureForCamera = Resources.Load<RenderTexture>("MapTexture");
            GetComponent<Camera>().targetTexture = referencesTextureForCamera;

        }


        void LateUpdate()
        {
            transform.position = playerfolowReferense.transform.position + Vector3.up * distanceUpperPlayerForCamera;
        }
    }
}
