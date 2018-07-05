using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;

    private void Start()
    {
        SpawnWaves();
    }

    void SpawnWaves()
    {
        Vector3 spawnPosition = new Vector3(Random. Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z) ;
        Quaternion spawnRotation = new Quaternion();
        Instantiate(hazard, spawnPosition, spawnRotation);
    }
}
