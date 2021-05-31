using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheFlavare.Basic.Data
{
    [System.Serializable]
    [CreateAssetMenu(fileName = "New Position Data", menuName = "Position Data", order = 51)]
    public class PositionData : ScriptableObject
    {
        [SerializeField]
        public string positionName;
        [SerializeField]
        public Vector3 position;
    }
}