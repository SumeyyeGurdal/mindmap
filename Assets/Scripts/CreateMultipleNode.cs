using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class CreateMultipleNode : MonoBehaviour
{
    public Transform rightHand;
    public GameObject multipleNode;
    public LineMaker lineMaker;

    public void InstantiateMultipleNode()
    {
        if (lineMaker.lastNode != null)
        {
            Instantiate(multipleNode, rightHand.position, rightHand.rotation);

        }
    }
}
