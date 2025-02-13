using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectSpawn;
    public float cooldown = 2f;

    public PhaseData[] phases;

    private int index;

    float timeStamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PhaseData phase = phases[index];
        if (Time.time >= phase.timeThreshold && index < phases.Length) 
        {
            index++;
            phase = phases [index];
        }

        if (Time.time - timeStamp >= cooldown)
        {
            Instantiate(objectSpawn, transform.position, transform.rotation);
            timeStamp = Time.time;
            cooldown = Random.Range(phase.minRange, phase.maxRange);
        }
        
    }
}
