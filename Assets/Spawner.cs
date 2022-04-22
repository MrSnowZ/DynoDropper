using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour{

    public enum SpawnState  { SPAWNING, WAITING, COUNTING };


    [System.Serializable]
    Public class Wave
    {
        public String name; 
        public Transform Candy;
        public int count;
        public float rate;
    }
        public Wave[] waves;
        private int nextWave = 0;

        public Transform[] spawnPoints;

        public float timeBetweenwaves = 5f;
        private float waveCountdown = 3f;

        private float searchCountdown = 1f;

        private SpawnState state = SpawnState.COUNTING;

        void Start () 
        {   
            if (spawnPoints.Length == 0) 
            {
                Debug.LogError ("No spawn points referenced.");


            waveCountdown = timeBetweenwaves;
        }

        void Update () 
        {
            if (state == SpawnState.WAITING) 
            {
                if (CandyIsAlive() ) 
                {
                    WaveCompleted();
                } else 
                {
                    return;
                }
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

        void WaveCompleted () 
        {
            Debug.Log("Wave Completed");

            state = SpawnState.COUNTING;
            waveCountdown = timeBetweenwaves;

            if (nextWave + 1 > waves.Length - 1 ) 
            {
                nextWave = 0;
                Debug.Log ("ALL WAVES COMPLETED! Looping...");
            } 
           else
            {
                nextWave++;
            }
            
         }

        bool CandyIsAlive() 
        {
            searchCountdown -= Time.deltaTime;
            if (searchCountdown <= 0f) 
            {
                searchCountdown = 1f;
                    if (GameObject.FindGameObjectWithTag ("Candy" == null)
                    {
                        return false;
                    }
            }

            
        }

        return true;
        
         {

        }
        
        IEnumerator SpawnWave (Wave _wave) 
        { 
            Debug.Log ("Spawning Wave: " + _wave.name);
            state = SpawnState.SPAWNING;

            for (int = 0; i < _wave.count; i++ )
            {
                SpawnCandy (_wave.candy);
                yeild return new WaitForSeconds ( 1f/_wave.rate  );
            }

            state = SpawnState.WAITING;

            yield break;
        }

        void SpawnCandy (Transform _candy) 
        {
            Debug.Log ("Spawing Candy: " + _Candy.name);

            Transform _sp = spawnPoints [ Random.Range (0, spawnPoints.Length) ];


        }
           Instantiate(_candy, _sp.position, _sp.rotation);
            
        
    }


}