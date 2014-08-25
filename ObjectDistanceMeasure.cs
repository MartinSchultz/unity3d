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
		if (null != Selection.objects && Selection.objects.Length > 1) {
			object1 = (GameObject)Selection.objects[0];
			object2 = (GameObject)Selection.objects[1];
		}

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

	public void Update()
	{
		// This is necessary to make the framerate normal for the editor window.
		Repaint();
	}

}
