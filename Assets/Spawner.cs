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

        public float timeBetweenwaves = 5f;
        private float waveCountdown = 3f;

        private float searchCountdown = 1f;

        private SpawnState state = SpawnState.COUNTING;

        void Start () 
        {   
            waveCountdown = timeBetweenwaves;
        }

        void Update () 
        {
            if (state == SpawnState.WAITING) 
            {
                if (CandyIsAlive() ) 
                {
                    // Begin a new round
                    Debug.Log ("Wave Completed!");

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
        }
           Instantiate(_candy, transform.position, transform.rotation);
            
        
    }


}