using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Transform cubeSpawnPoint;
    [SerializeField] private bool stateOfReadiness;
    [SerializeField] private float preparationTime = 5F;
    public Text textLabel;
    private void Update()
    {
        CreationCube();
    }

    public void Start()
    {
        textLabel.text = "Preparaion time = " + preparationTime;
    }

    void CreationCube()
    {
        if (Input.GetMouseButtonDown(0) && stateOfReadiness)
        {
            Instantiate(cube, cubeSpawnPoint.position, Quaternion.identity);
            StartCoroutine(ActionCube());
        }
    }
    IEnumerator ActionCube()
    {
        stateOfReadiness = false;
        yield return new WaitForSeconds(preparationTime);
        stateOfReadiness = true;
    }
}
