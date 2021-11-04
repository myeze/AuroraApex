using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour{
    public static LevelManager instance;

    public Transform respawnPoint;
    public GameObject playerPrefab;

    // Start is called before the first frame update
    private void Awake(){
        instance = this;
    }

    // Update is called once per frame
    public void Respawn()
    {
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    }
}
