using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public Vector3 offset = new Vector3(30, 0, 10);


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Offset the camare beside the plane by adding to the plane's possition
        transform.position = Player.transform.position + offset;
    }
}
