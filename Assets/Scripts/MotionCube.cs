using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotionCube : MonoBehaviour
{
    [SerializeField] private float speed = 20F;
    [SerializeField] private float cubeLife = 10F;
    public Vector3 direction;
    public Rigidbody rigidBody;
    public Text textLabelSpeed;
    public Text textLabelDistance;

    private void Start()
    {
        textLabelSpeed.text = "Speed = " + speed;
    }
    private void Update()
    {
        textLabelDistance.text = "Distance = " + transform.position.z;

        rigidBody.velocity = direction;
        direction = Vector3.forward;
        direction *= speed;
        Destroy(gameObject, cubeLife);
    }

}
