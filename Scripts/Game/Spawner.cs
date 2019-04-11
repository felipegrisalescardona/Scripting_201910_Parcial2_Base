using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    float SpawnCd = 5;
    [SerializeField]
    Transform SpawnPoint;
    [SerializeField]
    AICharacter[] EnemigosAIntanciar;
    int ActualEnemy = 0;
    float timecounter;
    


    public AICharacter SendNextOne()
    {
        ActualEnemy++;
        AICharacter NextOne;
        if (ActualEnemy >= EnemigosAIntanciar.Length)
        {
            ActualEnemy = 0;
        }
        NextOne = EnemigosAIntanciar[ActualEnemy];

        return NextOne;
    }
    public void SpawnSht()
    {
        AICharacter ActualEnemy = SendNextOne();
        ActualEnemy.transform.position = SpawnPoint.position;
        ActualEnemy.transform.rotation = transform.rotation;
        ActualEnemy.ModifyHP(100);
    }

    void Update()
    {
        timecounter += Time.deltaTime;
        if (timecounter >= SpawnCd)
        {
            Debug.Log(timecounter);
            SpawnSht();
            timecounter = 0;
        }
    }
}
