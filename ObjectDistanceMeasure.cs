using UnityEngine;
using UnityEditor;
using System.Collections;

public class ObjectDistanceMeasure : EditorWindow {
        
	GameObject object1;
	GameObject object2;

	[MenuItem("Tools/Distance Measure")]
	static void SceneLoadHelper() {
		ObjectDistanceMeasure window = (ObjectDistanceMeasure)EditorWindow.GetWindow (typeof (ObjectDistanceMeasure));
	}

	void OnGUI () {
		object1 = (GameObject)EditorGUILayout.ObjectField(object1, typeof(GameObject), true);
		object2 = (GameObject)EditorGUILayout.ObjectField(object2, typeof(GameObject), true);

		float distance3D = 0f;
		float distance2D = 0f;
		if (null != object1 && null != object2) {
			Vector3 pos1 = object1.transform.position;
			Vector3 pos2 = object2.transform.position;
			distance3D = Vector3.Distance (pos1, pos2);
			pos1.y = pos2.y = 0f;
			distance2D = Vector3.Distance (pos1, pos2);
		}
		GUILayout.Label ("3D Distance: " + distance3D);
		GUILayout.Label ("2D Distance: " + distance2D);
	}

}
