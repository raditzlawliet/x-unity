using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheFlavare.Basic.Data
{
    [ExecuteInEditMode]
    public class PositionDataScript : MonoBehaviour
    {
        [SerializeField]
        public PositionData data;
        void Start()
        {
            UpdateData();
        }

        void Awake()
        {
            UpdateData();
        }

        void Update()
        {
            if (transform.hasChanged)
                UpdateData();
        }

        void UpdateData()
        {
            if (data != null)
                data.position = transform.position;
        }
    }
}