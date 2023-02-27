using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace olci
{
    public class Rotate : MonoBehaviour
    {
        [SerializeField] private scriptobje _scriptobje;
        private void Update()
        {
            transform.Rotate(Vector3.up, _scriptobje.speed * Time.deltaTime);
        }
    }
}