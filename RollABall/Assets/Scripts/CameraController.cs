using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // Late Update is called once per frame but after all the other updates are done
    void LateUpdate() // camera pos wont be set until the player has moved for that frame
    {
        transform.position = player.transform.position + offset;
    }
}