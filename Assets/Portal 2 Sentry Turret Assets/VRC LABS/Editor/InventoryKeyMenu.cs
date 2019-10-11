using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class InventoryKeyMenu : MonoBehaviour
{

	[MenuItem("CONTEXT/Motion/Add Behaviour Keyframe")]
	private static void AddInventoryKey(MenuCommand command)
	{
		AnimationClip clip = command.context as AnimationClip;
		EditorCurveBinding[] bindings = UnityEditor.AnimationUtility.GetCurveBindings(clip);
		HashSet<string> keys = new HashSet<string>(bindings.Select(x => x.path));

		int num = 0;
		string newKeyPath = "RenameThis";
		while (keys.Contains(newKeyPath))
			newKeyPath = string.Format("RenameThis{0}", ++num);

		#pragma warning disable 0618
		AnimationUtility.SetEditorCurve(clip, newKeyPath, typeof(Behaviour), "m_Enabled", AnimationCurve.Linear(0.0f, 1.0f, 0.0f, 1.0f));        
		#pragma warning restore 0618
	}
}
