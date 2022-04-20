using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour{

    public enum SpawnState  { SPAWNING, WAITING, COUNTING };


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

        private SpawnState state = SpawnState.COUNTING;

        void Start () 
        {   
            waveCountdown = timeBetweenwaves;
        }

        void Update () 
        {
            if (state == SpawnState.WAITING) 
            {
                // Check if enemies are still alive
            }

            if (waveCountdown <= 0)
            {
                if (state != SpawnState.SPAWNING) 
                {
                    StartCoroutine ( SpawnWave ( waves[nextWave] ) );
                } 
            }
            else 
            {
                waveCountdown -= Time.deltaTime;
            }
        } 

        bool EnemyIsAlive() 
        {
            if (GameObject.FindGameObjectWithTag ("Enemy" == null)
        }
        return false;
        {

        }

        return true;
        
         {

        }
        
        IEnumerator SpawnWave (Wave _wave) 
        { 
            state = SpawnState.SPAWNING;

            for (int = 0; i < _wave.count; i++ )
            {
                SpawnEnemy (_wave.enemy);
                yeild return new WaitForSeconds ( 1f/_wave.rate  );
            }

            state = SpawnState.WAITING;

            yield break;
        }

        void SpawnEnemy (Transform _enemy) 
        {
            //spawn enemy
            Debug.Log ("Spawing Enemy: " + _enemmy.name);
        }
        
    }


}