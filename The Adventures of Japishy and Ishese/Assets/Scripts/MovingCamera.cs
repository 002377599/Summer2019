using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    private GameObject player;
    private GameObject player2;
    public float xmin;
    public float xmax;
    public float ymin;
    public float ymax;


    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("Player2");
        
    }

    // Update is called once per frame
    void Update()
    {

        //player1
        float x = Mathf.Clamp(player.transform.position.x,xmin,xmax);
        float y = Mathf.Clamp(player.transform.position.y, ymin, ymax);

        //player2
        float x2 = Mathf.Clamp(player2.transform.position.x, xmin, xmax);
        float y2 = Mathf.Clamp(player2.transform.position.y, ymin, ymax);

        gameObject.transform.position = new Vector3((x+x2)/2, (y+y2)/2, gameObject.transform.position.z);
    }
}
