using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class grass : MonoBehaviour {

	void Start () {
		float size = 0.07f;
		int count = 5000;
		float range = 5;

		var vertex = new List<Vector3> ();
		var index = new List<int> ();
		for (int I = 0, n = 0; I < count; ++I) {

			var a = Random.insideUnitSphere * size;
			var p1 = Random.insideUnitSphere * range;
			var p2 = p1 - a;
			var p3 = p1 + a;
			p1.y = 0.1f + Random.value * 0.4f;
			p2.y = 0;
			p3.y = 0;

			vertex.Add (p1);
			index.Add (n++);

			vertex.Add (p2);
			index.Add (n++);

			vertex.Add (p3);
			index.Add (n++);
		}

		var mesh = new Mesh ();
		mesh.SetVertices (vertex);
		mesh.SetIndices (index.ToArray (), MeshTopology.Triangles, 0);
		GetComponent<MeshFilter> ().sharedMesh = mesh;

	}

}