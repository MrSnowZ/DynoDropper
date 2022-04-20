using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour{


    [System.Serializable]
    Public class Wave
    {
        public String name; 
        public Transform enemy;
        public int count;
        public float rate;
    }
        public Wave[] waves;
        private int nextWave = 0;

        public float timeBetweenwaves = 5f;
        private float waveCountdown = 3f;

        void Start () {

        }
    }


}