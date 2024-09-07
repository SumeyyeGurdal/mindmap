using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineMaker : MonoBehaviour
{
    public Node lastNode;

    public void ClickedGrip()
    {
        // LineRenderer'ın pozisyon sayısını en az 2 olacak şekilde ayarla
        /* if (lastNode.lineRenderer.positionCount < 2)
        {
            lastNode.lineRenderer.positionCount = 2; // En az iki pozisyon olmalı
        } */

        // Pozisyonları ayarla
        lastNode.lineRenderer.SetPosition(1, transform.position);
        lastNode.lineRenderer.startWidth = 0.01f;
        lastNode.lineRenderer.endWidth = 0.01f;
    }
}
