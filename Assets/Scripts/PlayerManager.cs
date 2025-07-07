using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    public GameObject respawnPt;
    private Vector3 respawnPos;
    private int numOfEn;
    private Counter score;
    //private ScoresManager scoresManager = new ScoresManager();
    private StreamReader sr;
    private GameObject player;
    private GameObject OOB;
    //public Inventory inventory;
    public float fireRate;            // How fast the gun can shoot
    public float lastTimeShot;        // To keep track of the time between shots
    public float playerHealth;

    private void Start()
    {
        respawnPos = respawnPt.GetComponent<Transform>().position;
        fireRate = 2f;
        playerHealth = 100;
        player = GameObject.FindGameObjectWithTag("Player");
        OOB = GameObject.FindGameObjectWithTag("OOB");
    }
    void Update()
    {

    }
    public void MakeInvisible(GameObject obj)
    {
        obj.layer = LayerMask.NameToLayer("invisible");
        foreach (Transform child in obj.transform)
        {
            child.gameObject.layer = LayerMask.NameToLayer("invisible");
        }
    }

    public void MakeVisible(GameObject obj, int originalLayer)
    {
        obj.layer = originalLayer;
        foreach (Transform child in obj.transform)
        {
            child.gameObject.layer = originalLayer;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("OOB"))
        {
            Debug.Log("Collided with oob");
            this.transform.position = respawnPos;
        }
    }
}
