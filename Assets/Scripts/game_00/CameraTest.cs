using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    [SerializeField]
    private new Camera camera;

    private void OnDrawGizmos()
    {
        //Vector3[] corners = new Vector3[4];
        //camera.CalculateFrustumCorners(new Rect(camera.transform.position.x, camera.transform.position.y, 1, 1), camera.farClipPlane, Camera.MonoOrStereoscopicEye.Mono, corners);
        //foreach(Vector3 corner in corners)
        //{
        //    Gizmos.DrawSphere(corner, 1);
        //}
        //Vector3 p = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, camera.nearClipPlane));
        //Gizmos.color = Color.yellow;
        //Gizmos.DrawSphere(p, 0.5F);
        //Gizmos.color = Color.green;
        //Gizmos.DrawSphere(camera.transform.position, 1f);
        //Gizmos.Draw
    }



    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawSphere(new Vector3(boundary.xMin, boundary.yMin, 0), 0.1f);
    //    Gizmos.DrawSphere(new Vector3(boundary.xMax, boundary.yMax, 0), 0.1f);

    //}
}
