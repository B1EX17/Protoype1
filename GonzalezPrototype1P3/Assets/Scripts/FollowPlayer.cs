using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject player;
    private Vector3 offset = new Vector3(0, 7, -14);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
