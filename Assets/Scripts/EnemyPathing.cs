using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    List<Transform> waypoints;
    int waypointIndex = 0;    
    WaveConfig waveConfig;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = waveConfig.GetWaypoints();
        transform.position = waypoints[waypointIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();       
    }

    private void Move()
    {
        if (waypointIndex <= waypoints.Count - 1)
        {
            var targetPosition = waypoints[waypointIndex].transform.position;   //kam sa chcem dostat
            var movementThisFrame = waveConfig.GetMoveSpeed() * Time.deltaTime; //ako rychlo sa budem pohybovat
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, movementThisFrame);
            //kontrola si sme uz v cielovom bode
            if (transform.position == targetPosition)
            {
                waypointIndex++;
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetWaveConfig(WaveConfig waveConfig)
    {
        this.waveConfig = waveConfig;
    }

}
