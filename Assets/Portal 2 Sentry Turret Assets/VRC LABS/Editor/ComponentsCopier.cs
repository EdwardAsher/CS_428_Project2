using UnityEngine;
using UnityEditor;
using System.Collections;

public class ComponentsCopier : EditorWindow
{
    static Component[] copiedComponents;

    [MenuItem("GameObject/Copy all components %&c", false, -10)]
    static void Copy()
    {
        copiedComponents = Selection.activeGameObject.GetComponents<Component>();
    }

    [MenuItem("GameObject/Paste all components %&v", false, -10)]
    static void Paste()
    {
        foreach (var targetGameObject in Selection.gameObjects)
        {
            if (!targetGameObject || copiedComponents == null) continue;
            foreach (var copiedComponent in copiedComponents)
            {
                if (!copiedComponent) continue;
                UnityEditorInternal.ComponentUtility.CopyComponent(copiedComponent);
                UnityEditorInternal.ComponentUtility.PasteComponentAsNew(targetGameObject);
            }
        }
    }
}
