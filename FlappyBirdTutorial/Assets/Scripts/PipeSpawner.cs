using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipes;



    public float maxTime = 1;
    private float timer = 0;

    public float MaxHeight;
    public float MinHeight;

    private void Update()
    {
        CheckTimer();


    }

    private void CreatePipes()
    {
        GameObject NewPipes = Instantiate(Pipes); //create pipes
        NewPipes.transform.position = new Vector3(1.3f, Random.Range(MinHeight, MaxHeight), 1);//set position of new pipes
        Destroy(NewPipes, 15f);

    }

    private void CheckTimer()
    {
        if (timer > maxTime)
        {
            CreatePipes();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}
