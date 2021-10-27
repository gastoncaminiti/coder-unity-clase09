using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speedEnemy = 3.0f;
    [SerializeField] private int    liveEnemy = 3;

    private GameObject player;
    private Rigidbody rbEnemy;

    void Start()
    {
        player = GameObject.Find("Player");
        rbEnemy = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 playerDirection = GetPlayerDirection();
        //MOVIMIENTO POR FUERZA
        //rbEnemy.AddForce(playerDirection.normalized * speedEnemy);
        //Debug.Log("<color=#FF0000>UPDATE: "+Time.deltaTime+"</color>");
        /*
        if(playerDirection.magnitude > 3)
        {
            LookAtPlayer(playerDirection);
            MoveTowards(playerDirection);
        }
        */
    }

    private void FixedUpdate()
    {
        Debug.Log("<color=#00FF00>FIX UPDATE: " + Time.deltaTime + "</color>");
        Vector3 playerDirection = GetPlayerDirection();
        //rbEnemy.rotation = Quaternion.LookRotation(playerDirection));
        rbEnemy.rotation = Quaternion.LookRotation(new Vector3(playerDirection.x, 0, playerDirection.z));
        rbEnemy.AddForce(playerDirection * speedEnemy);
        
    }
    /*
    private void MoveTowards(Vector3 newDirection)
    {
        //Vector3 direction   = (player.transform.position - transform.position).normalized;
        transform.position += speedEnemy * newDirection.normalized * Time.deltaTime;
    }

    private void LookAtPlayer(Vector3 newDirection)
    {
        Quaternion newRotation = Quaternion.LookRotation(newDirection);
        transform.rotation = newRotation;
    }
    */

    private Vector3 GetPlayerDirection()
    {
        return player.transform.position - transform.position;
    }

}
