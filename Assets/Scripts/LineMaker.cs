using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMaker : MonoBehaviour
{
    public Node lastNode;

    public void ClickedGrip()
    {
        lastNode.lineRenderer.SetPosition(1, transform.position);
    }


} 
