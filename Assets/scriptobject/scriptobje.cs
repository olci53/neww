using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace olci
{
    [CreateAssetMenu(menuName = "olci/olci1/Rotate Settings")]
    public class scriptobje : ScriptableObject
    {
        [SerializeField] private float _speed = 1;
        public float speed { get { return _speed; } }

    }
}