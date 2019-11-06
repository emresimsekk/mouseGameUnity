using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AIControl : MonoBehaviour
{

    node[] pathNode;

  
    public GameObject player;
    public float moveSpeed;
    float timer;
    int currentNode;

    static Vector3 currentPositionHolder;
    SpriteRenderer spriteRenderer;
 

    void Start()
    {
       
        pathNode = GetComponentsInChildren<node>();
        checkNode();
        
    }


    void Update()
    {

        timer += Time.deltaTime * moveSpeed;
        if (player.transform.position != currentPositionHolder)
        {
            player.transform.position = Vector3.Lerp(player.transform.position, currentPositionHolder, timer);
        }
        else
        {
            if (currentNode < pathNode.Length - 1)
            {
             
               
                currentNode++;
                checkNode();
            }

        }
    }

    void checkNode()
    {
        if (currentNode < pathNode.Length - 1)
        { timer = 0; }
        currentPositionHolder = pathNode[currentNode].transform.position;
    }
}
