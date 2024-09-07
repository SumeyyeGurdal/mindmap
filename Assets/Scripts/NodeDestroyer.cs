using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeDestroyer : MonoBehaviour
{
    public GameObject[] allNodes;
      private void OnTriggerEnter(Collider other)
    {
            Debug.Log("collided");


        if (other.CompareTag("RightHand"))
        {
            for (int i = 0; i < allNodes.Length; i++)
            {
                Destroy(allNodes[i]);
            }
            

        }
    }
}
