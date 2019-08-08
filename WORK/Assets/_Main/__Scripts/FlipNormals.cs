using UnityEngine;
using System.Collections;

///Summary:
/// This script flips a object inside out and I am using this for the screen because the screen is a sphere and the camera is placed inside the sphere
public class FlipNormals : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;

        Vector3[] normals = mesh.normals;
        for (int i = 0; i < normals.Length; i++)
            normals[i] = -1 * normals[i];

        mesh.normals = normals;

        for(int i = 0; i < mesh.subMeshCount; i++)
        {
            int[] tris = mesh.GetTriangles(i);
            for(int j = 0; j< tris.Length; j += 3)
            {
                int temp = tris[j];
                tris[j] = tris[j + 1];
                tris[j + 1] = temp;
            }

            mesh.SetTriangles(tris, i);
        }
    }
}