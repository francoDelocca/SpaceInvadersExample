using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    [Header("LimiteUno")]
    [SerializeField]
    private GameObject limitOne;

    [Header("LimiteDos")]
    [SerializeField]
    private GameObject limitTwo;

    [Header("Objeto a spawnear")]
    public GameObject objectToSpawn;


    private Vector2 position;
    

    // Start is called before the first frame update
    void Start()
    {

        var positionOne = limitOne.transform.position.x;
        var positionTwo = limitTwo.transform.position.x;

        position = new Vector2(Random.Range(positionOne >= 0 ? positionOne - 1f: positionOne + 1f, positionTwo >= 0 ? positionTwo - 1f : positionTwo + 1f), objectToSpawn.transform.position.y);

        objectToSpawn.transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
