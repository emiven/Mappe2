using UnityEngine;
using System.Collections;

public class ColourChange : MonoBehaviour {
	void Update () 
	{
		Mesh mesh = GetComponent<MeshFilter>().mesh;
		Vector3[] vertices = mesh.vertices;
		Color[] colors = new Color[vertices.Length];
		for (int i = 0; i < vertices.Length; i++)
		{
			colors[i] = Color.red;
		}
		mesh.colors = colors;
	}

	}

//	public Vector3 contactPoint;
//	public Vector3 nearestVert;
//
//	Mesh mesh;
//	Vector3[] verts;
//	Vector3 vertPos;
//	Color[] colors;
//
//	void Start () {
//		mesh = GetComponent<MeshFilter>().mesh;
//		verts = mesh.vertices;
//		colors = mesh.colors;
//	}
//
//	void Update () {
//		colors[NearestVertexTo(contactPoint)] = Color.red;
//		mesh.colors = colors;
//	}
//
//	int NearestVertexTo(Vector3 point) {
//		point = transform.InverseTransformPoint(point);
//
//		float minDistanceSqr = Mathf.Infinity;
//		int nearestVertex = -1; 
//
//		// scan all vertices to find nearest
//		for (int i = 0; i < verts.Length; i++) {
//			float distSqr = (point - verts[i]).sqrMagnitude;
//
//			if (distSqr < minDistanceSqr) {
//				minDistanceSqr = distSqr;
//				nearestVertex = i;
//			}
//		}
//		return nearestVertex;
//	}
//
//	void OnCollisionStay2D(Collision2D collision) {
//		foreach (ContactPoint2D contact in collision.contacts) {
//			Debug.DrawRay(contact.point, Vector3.up, Color.green, 4, false);
//			contactPoint = contact.point;
//		}
//	}
//}
