using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool dog = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (!dog && Input.GetKeyDown(KeyCode.Space))
        {
            dog = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("ResetDog", 1.0f);
        }
    }

    void ResetDog()
    {
        dog = false;
    }
}
