using HarmonyLib;
using UnityEngine;

[HarmonyPatch(typeof(GameObject))]
[HarmonyPatch("CreatePrimitive", MethodType.Normal)]
internal class MenuFixer : MonoBehaviour
{
    /*
       COPYRIGHT NOTE: THIS TEMPLATE IS COPYRIGHTED MATERIAL FROM "Project Malachi" AND AT ALL TIMES 
       MUST BE CREDITTED. IF ANY MATERIAL FROM "MalachiTemp" FOUND IN ANY OTHER PROJECT/THING WITHOUT 
       CREDIT OR PERMISSION MUST AND WILL BE REMOVED IMMEDIATELY
    */
    private static void Postfix(GameObject __result)
    {
        __result.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
    }
}