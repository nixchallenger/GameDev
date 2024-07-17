using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStrafeAnimationLeft : MonoBehaviour
{
    public float speed = 1000.0f;
    [SerializeField] private Animator controller;


    // Start is called before the first frame update
    void Start()
    {
        // Ensure the Animator component is correctly referenced
        if (controller == null)
        {
            Debug.LogError("Animator controller is not assigned.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) // Changed from GetKeyDown to GetKey for continuous checking
        {
            Debug.Log("left arrow key is held down.");
            controller.SetBool("PlayerMove", true);
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            Debug.Log("left arrow key was released.");
            transform.position = transform.position + new Vector3(0, 0, 0);
            controller.SetBool("PlayerMove", false);
        }

        if (Input.GetKey(KeyCode.RightArrow)) // Changed from GetKeyDown to GetKey for continuous checking
        {
            Debug.Log("Right arrow key is held down.");
            controller.SetBool("PlayerMove", true);
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            Debug.Log("Right arrow key was released.");
            transform.position = transform.position + new Vector3(0, 0, 0);
            controller.SetBool("PlayerMove", false);
        }
    }
}
