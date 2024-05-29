﻿using Malachis_Temp;
using UnityEngine;

namespace Loading
{
    /*
       COPYRIGHT NOTE: THIS TEMPLATE IS COPYRIGHTED MATERIAL FROM "Project Malachi" AND AT ALL TIMES 
       MUST BE CREDITTED. IF ANY MATERIAL FROM "MalachiTemp" FOUND IN ANY OTHER PROJECT/THING WITHOUT 
       CREDIT OR PERMISSION MUST AND WILL BE REMOVED IMMEDIATELY
    */
    public class Loader : MonoBehaviour
    {
        private static GameObject gameobject;
        public static bool loaded = false;
        public static void Load()
        {
            gameobject = new GameObject();
            gameobject.AddComponent<Plugin>();
            UnityEngine.Object.DontDestroyOnLoad(gameobject);
        }

    }
}
