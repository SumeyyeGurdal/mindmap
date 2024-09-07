using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class NodeMaker : MonoBehaviour
{
    public Transform rightHand;
    public GameObject nodePrefab;
    public LineMaker lineMaker;

    public void InstantiateNode()
    {
        GameObject lastNode = Instantiate(nodePrefab, rightHand.position, rightHand.rotation);
        lineMaker.lastNode = lastNode.GetComponent<Node>();
    }

    
}