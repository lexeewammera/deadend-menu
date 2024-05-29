using BepInEx;
using dark.efijiPOIWikjek;
using ExitGames.Client.Photon;
using GorillaNetworking;
using GTAG_NotificationLib;
using Photon.Pun;
using Photon.Realtime;
using MalachiTemp.UI;
using MalachiTemp.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Application = UnityEngine.Application;
using Object = UnityEngine.Object;
using Text = UnityEngine.UI.Text;
using UnityEngine.SocialPlatforms;
using System.Diagnostics;


namespace MalachiTemp.Backend
{
    /*
       COPYRIGHT NOTE: THIS TEMPLATE IS COPYRIGHTED MATERIAL FROM "Project Malachi" AND AT ALL TIMES 
       MUST BE CREDITTED. IF ANY MATERIAL FROM "MalachiTemp" FOUND IN ANY OTHER PROJECT/THING WITHOUT 
       CREDIT OR PERMISSION MUST AND WILL BE REMOVED IMMEDIATELY
    */
    internal class Mods : MonoBehaviour
    {
        public static void HeadSpin()
        {
            Mods.head1();
            if (Mods.Head1)
            {
                VRMap head = RigShit.GetOwnVRRig().head;
                head.trackingRotationOffset.y = head.trackingRotationOffset.y + 15f;
            }
        }
        public static void HeadSpinV2()
        {
            Mods.Head2();
            if (Mods.head2)
            {
                VRMap head = RigShit.GetOwnVRRig().head;
                head.trackingRotationOffset.z = head.trackingRotationOffset.z + 15f;
            }
        }
        
        public static void lognarms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.25f, 1.25f, 1.25f);
        }

        public static void fixarms()
        {
            GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
        }
        public static void monstershand()
        {
            foreach (MonkeyeAI monkeyeAI in UnityEngine.Object.FindObjectsOfType<MonkeyeAI>())
            {
                monkeyeAI.transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
        }
        public static void bigmonsters()
        {
            foreach (MonkeyeAI monkeyeAI in UnityEngine.Object.FindObjectsOfType<MonkeyeAI>())
            {
                monkeyeAI.transform.localScale = new UnityEngine.Vector3(10f, 10f, 10f);
            }
        }
        public static void OwnerBug()
        {
            ThrowableBug component = GameObject.Find("Floating Bug Holdable").GetComponent<ThrowableBug>();
            component.WorldShareableRequestOwnership();
        }

        public static void declarebug()
        {
            GameObject thatfuckingbugthatihate = GameObject.Find("Floating Bug Holdable");
            thatfuckingbugthatihate.transform.position = new UnityEngine.Vector3(2f, 3f, 2f);
        }

        public static void bigassbug()
        {
            GameObject thatfuckingbigassbug = GameObject.Find("Floating Bug Holdable");
            thatfuckingbigassbug.transform.localScale = new Vector3(5f, 5f, 5f);
        }

        public static void whyisthebugsobig()
        {
            GameObject thatfuckinghugebug = GameObject.Find("Floating Bug Holdable");
            thatfuckinghugebug.transform.localScale = new UnityEngine.Vector3(9f, 9f, 9f);

        }

        public static void bigasmapbug()
        {
            GameObject bigbug = GameObject.Find("Floating Bug Holdable");
            bigbug.transform.localScale = new UnityEngine.Vector3(20f, 20f, 20f);
        }

        public static void whatthebatdoin()
        {
            GameObject whatthebat = GameObject.Find("Cave Bat Holdable");
            whatthebat.transform.position = GorillaTagger.Instance.transform.position;
        }

        public static void bigassbat()
        {
            GameObject whatthebat = GameObject.Find("Cave Bat Holdable");
            whatthebat.transform.localScale = new UnityEngine.Vector3(9f, 9f, 9f);
        }
        public static void HeadSpinV3()
        {
            Mods.Head3();
            if (Mods.head3)
            {
                VRMap head = RigShit.GetOwnVRRig().head;
                head.trackingRotationOffset.x = head.trackingRotationOffset.x + 15f;
            }
        }
        public static void fix1()
        {
            if (Mods.Head1)
            {
                RigShit.GetOwnVRRig().head.trackingRotationOffset.y = 0f;
                Mods.Head1 = false;
            }
        }
        public static void fix2()
        {
            if (Mods.head2)
            {
                RigShit.GetOwnVRRig().head.trackingRotationOffset.z = 0f;
                Mods.head2 = false;
            }
        }
        public static void fix3()
        {
            if (Mods.head3)
            {
                RigShit.GetOwnVRRig().head.trackingRotationOffset.x = 0f;
                Mods.head3 = false;
            }
        }
        public static void fix4()
        {
            if (Mods.headback)
            {
                RigShit.GetOwnVRRig().head.trackingRotationOffset.y = 0f;
                Mods.headback = false;
            }
        }
        public static void fix5()
        {
            if (Mods.downhead)
            {
                RigShit.GetOwnVRRig().head.trackingRotationOffset.z = 0f;
                Mods.downhead = false;
            }
        }
        public static void backhead()
        {
            Mods.Headback();
            if (Mods.headback)
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
            }
        }
        public static void upsidedownhead()
        {
            Mods.Uphead();
            if (Mods.downhead)
            {
                GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
            }
        }
        [Obsolete]
        public static void FPSboost()
        {
            Mods.Fps();
            if (Mods.fps)
            {
                QualitySettings.masterTextureLimit = 999999999;

                QualitySettings.masterTextureLimit = 999999999;

                QualitySettings.globalTextureMipmapLimit = 999999999;

                QualitySettings.maxQueuedFrames = 60; 
            }
        }
        public static void fixFPS()
        {
            if (Mods.fps)
            {
                QualitySettings.masterTextureLimit = default;

                QualitySettings.masterTextureLimit = default;

                QualitySettings.globalTextureMipmapLimit = default;

                QualitySettings.maxQueuedFrames = default;
                Mods.fps = false;
            }
        }
        public static void WASD()
        {
            Transform cam = Camera.main.transform;
            GorillaTagger.Instance.rigidbody.useGravity = false;
            GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
            float NSpeed = Mods.FCMovmentSpeed * Time.deltaTime;
            if (UnityInput.Current.GetKey(KeyCode.LeftShift) || UnityInput.Current.GetKey(KeyCode.RightShift))
            {
                NSpeed *= 10f;
            }
            if (UnityInput.Current.GetKey(KeyCode.LeftArrow) || UnityInput.Current.GetKey(KeyCode.A))
            {
                GorillaLocomotion.Player.Instance.transform.position += Camera.main.transform.right * -1f * NSpeed;
            }
            if (UnityInput.Current.GetKey(KeyCode.RightArrow) || UnityInput.Current.GetKey(KeyCode.D))
            {
                GorillaLocomotion.Player.Instance.transform.position += Camera.main.transform.right * NSpeed;
            }
            if (UnityInput.Current.GetKey(KeyCode.UpArrow) || UnityInput.Current.GetKey(KeyCode.W))
            {
                GorillaLocomotion.Player.Instance.transform.position += Camera.main.transform.forward * NSpeed;
            }
            if (UnityInput.Current.GetKey(KeyCode.DownArrow) || UnityInput.Current.GetKey(KeyCode.S))
            {
                GorillaLocomotion.Player.Instance.transform.position += Camera.main.transform.forward * -1f * NSpeed;
            }
            if (UnityInput.Current.GetKey(KeyCode.Space) || UnityInput.Current.GetKey(KeyCode.PageUp))
            {
                GorillaLocomotion.Player.Instance.transform.position += Camera.main.transform.up * NSpeed;
            }
            if (UnityInput.Current.GetKey(KeyCode.LeftControl) || UnityInput.Current.GetKey(KeyCode.PageDown))
            {
                GorillaLocomotion.Player.Instance.transform.position += Camera.main.transform.up * -1f * NSpeed;
            }
            if (UnityInput.Current.GetMouseButton(1))
            {
                Vector3 val = UnityInput.Current.mousePosition - Mods.previousMousePosition;
                float num2 = GorillaLocomotion.Player.Instance.transform.localEulerAngles.y + val.x * 0.3f;
                float num3 = GorillaLocomotion.Player.Instance.transform.localEulerAngles.x - val.y * 0.3f;
                cam.localEulerAngles = new Vector3(num3, num2, 0f);
            }
            Mods.previousMousePosition = UnityInput.Current.mousePosition;
        }
        public static void Platforms()
        {
            Mods.PlatformsThing(Mods.invisplat, Mods.stickyplatforms);
        }
        public static void Invisableplatforms()
        {
            Mods.PlatformsThing(true, false);
        }
        public static void Stickyplats()
        {
            Mods.PlatformsThing(false, true);
        }
        public static void invisstickyplats()
        {
            Mods.PlatformsThing(true, true);
        }
        public static void Noclip()
        {
            bool flag = WristMenu.triggerDownR;
            if (flag)
            {
                foreach (MeshCollider meshCollider in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider.enabled = false;
                }
            }
            else
            {
                foreach (MeshCollider meshCollider2 in Resources.FindObjectsOfTypeAll<MeshCollider>())
                {
                    meshCollider2.enabled = true;
                }
            }
        }
        public static void quit()
        {
            Application.Quit();
        }
        public static void LongArms()
        {
            Mods.one();
            if (Mods.longArms)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
            }
        }
        public static void longerArms()
        {
            Mods.two();
            if (Mods.longerarms)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.8f, 1.8f, 1.8f);
            }
        }
        public static void longererArms()
        {
            Mods.three();
            if (Mods.longlongarms)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(2.1f, 2.1f, 2.1f);
            }
        }
        public static void resetarms()
        {
            if (Mods.longArms)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
                Mods.longArms = false;
            }
        }
        public static void normarms()
        {
            if (Mods.longerarms)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
                Mods.longerarms = false;
            }
        }
        public static void normarms2()
        {
            if (Mods.longlongarms)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1f, 1f, 1f);
                Mods.longlongarms = false;
            }
        }
        public static void Moo()
        {
            // custom boards
            GameObject.Find("motdtext").GetComponent<Text>().text = "hello :3"; // this is the text on the motd
            GameObject.Find("motd").GetComponent<Text>().text = "<color=white>" + WristMenu.MenuTitle + " </color>"; // this is the text at the top of the motd
            GameObject.Find("CodeOfConduct").GetComponent<Text>().text = "<color=white>COC</color>"; // this is the text at the top of the coc
            GameObject.Find("COC Text").GetComponent<Text>().text = "<color=white> hello :3 </color>"; // this is the text on the coc
        }
        public static void Fly()
        {
            if (WristMenu.abuttonDown)
            {
                if (Mods.change5 == 1)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -9.81f, 0f);
                }
                if (Mods.change5 == 2)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -3f, 0f);
                }
                if (Mods.change5 == 3)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 15f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, 0f, 0f);
                }
            }
        }
        public static void fastFly()
        { 
            if (WristMenu.abuttonDown)
            {
                if (Mods.change5 == 1)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 30f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -9.81f, 0f);
                }
                if (Mods.change5 == 2)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 30f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -3f, 0f);
                }
                if (Mods.change5 == 3)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 30f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, 0f, 0f);
                }
            }
        }
        public static void hellafastFly()
        {
            if (WristMenu.abuttonDown)
            {
                if (Mods.change5 == 1)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 60f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -9.81f, 0f);
                }
                if (Mods.change5 == 2)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 60f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -3f, 0f);
                }
                if (Mods.change5 == 3)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 60f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, 0f, 0f);
                }
            }
        }
        public static void slowFly()
        {
            if (WristMenu.abuttonDown)
            {
                if (Mods.change5 == 1)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 7f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -9.81f, 0f);
                }
                if (Mods.change5 == 2)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 7f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, -3f, 0f);
                }
                if (Mods.change5 == 3)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaLocomotion.Player.Instance.headCollider.transform.forward * Time.deltaTime * 7f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                    Physics.gravity = new Vector3(0f, 0f, 0f);
                }
            }
        }
        public static void Ghostmonke()
        {
            if (Mods.right)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = !Mods.ghostMonke;
                bool ghostMonke = Mods.ghostMonke;
                if (ghostMonke)
                {
                    Mods.orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Object.Destroy(Mods.orb.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb.GetComponent<SphereCollider>());
                    Mods.orb.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    Mods.orb2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Object.Destroy(Mods.orb2.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb2.GetComponent<SphereCollider>());
                    Mods.orb2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb2.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    if (Mods.change8 == 1)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.blue;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.blue;
                    }
                    if (Mods.change8 == 2)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.red;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.red;
                    }
                    if (Mods.change8 == 3)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.white;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.white;
                    }
                    if (Mods.change8 == 4)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.green;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.green;
                    }
                    if (Mods.change8 == 5)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.magenta;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.magenta;
                    }
                    if (Mods.change8 == 6)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.cyan;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.cyan;
                    }
                    if (Mods.change8 == 7)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.yellow;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.yellow;
                    }
                    if (Mods.change8 == 8)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.black;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.black;
                    }
                    if (Mods.change8 == 9)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.grey;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.grey;
                    }
                    if (Mods.change8 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        Mods.orb.GetComponent<Renderer>().material.color = color;
                        Mods.orb2.GetComponent<Renderer>().material.color = color;
                    }
                    Object.Destroy(Mods.orb, Time.deltaTime);
                    Object.Destroy(Mods.orb2, Time.deltaTime);
                }
                bool flag2 = WristMenu.ybuttonDown && !Mods.lastHit;
                if (flag2)
                {
                    Mods.ghostMonke = !Mods.ghostMonke;
                }
                Mods.lastHit = WristMenu.ybuttonDown;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = !Mods.ghostMonke;
                bool ghostMonke1 = Mods.ghostMonke;
                if (ghostMonke1)
                {
                    Mods.orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Object.Destroy(Mods.orb.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb.GetComponent<SphereCollider>());
                    Mods.orb.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    Mods.orb2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Object.Destroy(Mods.orb2.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb2.GetComponent<SphereCollider>());
                    Mods.orb2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb2.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    if (Mods.change8 == 1)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.blue;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.blue;
                    }
                    if (Mods.change8 == 2)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.red;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.red;
                    }
                    if (Mods.change8 == 3)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.white;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.white;
                    }
                    if (Mods.change8 == 4)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.green;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.green;
                    }
                    if (Mods.change8 == 5)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.magenta;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.magenta;
                    }
                    if (Mods.change8 == 6)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.cyan;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.cyan;
                    }
                    if (Mods.change8 == 7)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.yellow;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.yellow;
                    }
                    if (Mods.change8 == 8)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.black;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.black;
                    }
                    if (Mods.change8 == 9)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.grey;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.grey;
                    }
                    if (Mods.change8 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        Mods.orb.GetComponent<Renderer>().material.color = color;
                        Mods.orb2.GetComponent<Renderer>().material.color = color;
                    }
                    Object.Destroy(Mods.orb, Time.deltaTime);
                    Object.Destroy(Mods.orb2, Time.deltaTime);
                }
                bool flag3 = WristMenu.bbuttonDown && !Mods.lastHit;
                if (flag3)
                {
                    Mods.ghostMonke = !Mods.ghostMonke;
                }
                Mods.lastHit = WristMenu.bbuttonDown;
            }
        }
        public static void GhostMonkeGUI()
        {
            Mods.GhostMonk();
            if (Mods.GhostMonkGUI)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                Mods.orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Object.Destroy(Mods.orb.GetComponent<Rigidbody>());
                Object.Destroy(Mods.orb.GetComponent<SphereCollider>());
                Mods.orb.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                Mods.orb.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                Mods.orb2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Object.Destroy(Mods.orb2.GetComponent<Rigidbody>());
                Object.Destroy(Mods.orb2.GetComponent<SphereCollider>());
                Mods.orb2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                Mods.orb2.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                if (Mods.change8 == 1)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.blue;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (Mods.change8 == 2)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.red;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.red;
                }
                if (Mods.change8 == 3)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.white;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.white;
                }
                if (Mods.change8 == 4)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.green;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.green;
                }
                if (Mods.change8 == 5)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.magenta;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.magenta;
                }
                if (Mods.change8 == 6)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.cyan;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.cyan;
                }
                if (Mods.change8 == 7)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.yellow;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.yellow;
                }
                if (Mods.change8 == 8)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.black;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.black;
                }
                if (Mods.change8 == 9)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.grey;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.grey;
                }
                if (Mods.change8 == 10)
                {
                    GradientColorKey[] array = new GradientColorKey[7];
                    array[0].color = Color.red;
                    array[0].time = 0f;
                    array[1].color = Color.yellow;
                    array[1].time = 0.2f;
                    array[2].color = Color.green;
                    array[2].time = 0.3f;
                    array[3].color = Color.cyan;
                    array[3].time = 0.5f;
                    array[4].color = Color.blue;
                    array[4].time = 0.6f;
                    array[5].color = Color.magenta;
                    array[5].time = 0.8f;
                    array[6].color = Color.red;
                    array[6].time = 1f;
                    Gradient gradient = new Gradient();
                    gradient.colorKeys = array;
                    float num = Mathf.PingPong(Time.time / 2f, 1f);
                    Color color = gradient.Evaluate(num);
                    Mods.orb.GetComponent<Renderer>().material.color = color;
                    Mods.orb2.GetComponent<Renderer>().material.color = color;
                }
                Object.Destroy(Mods.orb, Time.deltaTime);
                Object.Destroy(Mods.orb2, Time.deltaTime);
            }
        }
        public static void OffGhostMonkeGUI()
        {
            if (Mods.GhostMonkGUI)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
                Mods.GhostMonkGUI = false;
            }
        }
        public static void Invis()
        {
            if (Mods.right)
            {
                bool invisMonke = Mods.invisMonke;
                if (invisMonke)
                {
                    GorillaTagger.Instance.offlineVRRig.headBodyOffset = new Vector3(9999f, 9999f, 9999f);
                    Mods.orb = GameObject.CreatePrimitive(0);
                    Object.Destroy(Mods.orb.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb.GetComponent<SphereCollider>());
                    Mods.orb.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    Mods.orb2 = GameObject.CreatePrimitive(0);
                    Object.Destroy(Mods.orb2.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb2.GetComponent<SphereCollider>());
                    Mods.orb2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    if (Mods.change8 == 1)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.blue;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.blue;
                    }
                    if (Mods.change8 == 2)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.red;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.red;
                    }
                    if (Mods.change8 == 3)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.white;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.white;
                    }
                    if (Mods.change8 == 4)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.green;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.green;
                    }
                    if (Mods.change8 == 5)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.magenta;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.magenta;
                    }
                    if (Mods.change8 == 6)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.cyan;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.cyan;
                    }
                    if (Mods.change8 == 7)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.yellow;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.yellow;
                    }
                    if (Mods.change8 == 8)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.black;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.black;
                    }
                    if (Mods.change8 == 9)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.grey;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.grey;
                    }
                    if (Mods.change8 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        Mods.orb.GetComponent<Renderer>().material.color = color;
                        Mods.orb2.GetComponent<Renderer>().material.color = color;
                    }
                    Object.Destroy(Mods.orb, Time.deltaTime);
                    Object.Destroy(Mods.orb2, Time.deltaTime);
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.headBodyOffset = (GorillaTagger.Instance.offlineVRRig.headBodyOffset = Vector3.zero);
                }
                bool flag2 = WristMenu.ybuttonDown && !Mods.lastHit2;
                if (flag2)
                {
                    Mods.invisMonke = !Mods.invisMonke;
                }
                Mods.lastHit2 = WristMenu.ybuttonDown;
            }
            else
            {
                bool invisMonke1 = Mods.invisMonke;
                if (invisMonke1)
                {
                    GorillaTagger.Instance.offlineVRRig.headBodyOffset = new Vector3(9999f, 9999f, 9999f);
                    Mods.orb = GameObject.CreatePrimitive(0);
                    Object.Destroy(Mods.orb.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb.GetComponent<SphereCollider>());
                    Mods.orb.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                    Mods.orb2 = GameObject.CreatePrimitive(0);
                    Object.Destroy(Mods.orb2.GetComponent<Rigidbody>());
                    Object.Destroy(Mods.orb2.GetComponent<SphereCollider>());
                    Mods.orb2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    Mods.orb2.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                    if (Mods.change8 == 1)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.blue;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.blue;
                    }
                    if (Mods.change8 == 2)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.red;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.red;
                    }
                    if (Mods.change8 == 3)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.white;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.white;
                    }
                    if (Mods.change8 == 4)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.green;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.green;
                    }
                    if (Mods.change8 == 5)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.magenta;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.magenta;
                    }
                    if (Mods.change8 == 6)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.cyan;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.cyan;
                    }
                    if (Mods.change8 == 7)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.yellow;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.yellow;
                    }
                    if (Mods.change8 == 8)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.black;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.black;
                    }
                    if (Mods.change8 == 9)
                    {
                        Mods.orb.GetComponent<Renderer>().material.color = Color.grey;
                        Mods.orb2.GetComponent<Renderer>().material.color = Color.grey;
                    }
                    if (Mods.change8 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        Mods.orb.GetComponent<Renderer>().material.color = color;
                        Mods.orb2.GetComponent<Renderer>().material.color = color;
                    }
                    Object.Destroy(Mods.orb, Time.deltaTime);
                    Object.Destroy(Mods.orb2, Time.deltaTime);
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.headBodyOffset = (GorillaTagger.Instance.offlineVRRig.headBodyOffset = Vector3.zero);
                }
                bool flag3 = WristMenu.bbuttonDown && !Mods.lastHit2;
                if (flag3)
                {
                    Mods.invisMonke = !Mods.invisMonke;
                }
                Mods.lastHit2 = WristMenu.bbuttonDown;
            }
        }
        public static void InvisMonkeGUI()
        {
            Mods.InvisMonk();
            if (Mods.InvisMonkGUI)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset = new Vector3(9999f, 9999f, 9999f);
                Mods.orb = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Object.Destroy(Mods.orb.GetComponent<Rigidbody>());
                Object.Destroy(Mods.orb.GetComponent<SphereCollider>());
                Mods.orb.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                Mods.orb.transform.position = GorillaTagger.Instance.leftHandTransform.position;
                Mods.orb2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                Object.Destroy(Mods.orb2.GetComponent<Rigidbody>());
                Object.Destroy(Mods.orb2.GetComponent<SphereCollider>());
                Mods.orb2.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                Mods.orb2.transform.position = GorillaTagger.Instance.rightHandTransform.position;
                if (Mods.change8 == 1)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.blue;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (Mods.change8 == 2)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.red;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.red;
                }
                if (Mods.change8 == 3)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.white;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.white;
                }
                if (Mods.change8 == 4)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.green;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.green;
                }
                if (Mods.change8 == 5)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.magenta;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.magenta;
                }
                if (Mods.change8 == 6)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.cyan;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.cyan;
                }
                if (Mods.change8 == 7)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.yellow;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.yellow;
                }
                if (Mods.change8 == 8)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.black;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.black;
                }
                if (Mods.change8 == 9)
                {
                    Mods.orb.GetComponent<Renderer>().material.color = Color.grey;
                    Mods.orb2.GetComponent<Renderer>().material.color = Color.grey;
                }
                if (Mods.change8 == 10)
                {
                    GradientColorKey[] array = new GradientColorKey[7];
                    array[0].color = Color.red;
                    array[0].time = 0f;
                    array[1].color = Color.yellow;
                    array[1].time = 0.2f;
                    array[2].color = Color.green;
                    array[2].time = 0.3f;
                    array[3].color = Color.cyan;
                    array[3].time = 0.5f;
                    array[4].color = Color.blue;
                    array[4].time = 0.6f;
                    array[5].color = Color.magenta;
                    array[5].time = 0.8f;
                    array[6].color = Color.red;
                    array[6].time = 1f;
                    Gradient gradient = new Gradient();
                    gradient.colorKeys = array;
                    float num = Mathf.PingPong(Time.time / 2f, 1f);
                    Color color = gradient.Evaluate(num);
                    Mods.orb.GetComponent<Renderer>().material.color = color;
                    Mods.orb2.GetComponent<Renderer>().material.color = color;
                }
                Object.Destroy(Mods.orb, Time.deltaTime);
                Object.Destroy(Mods.orb2, Time.deltaTime);
            }
        }
        public static void OffInvisMonkeGUI()
        {
            if (Mods.InvisMonkGUI)
            {
                GorillaTagger.Instance.offlineVRRig.headBodyOffset = (GorillaTagger.Instance.offlineVRRig.headBodyOffset = Vector3.zero);
                Mods.InvisMonkGUI = false;
            }
        }
        public static void Tracers()
        {
            foreach (Player player in PhotonNetwork.PlayerListOthers)
            {
                PhotonView photonView = GorillaGameManager.instance.FindVRRigForPlayer(player);
                VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(player);
                bool flag = !vrrig.isOfflineVRRig && !vrrig.isMyPlayer && !photonView.IsMine && !vrrig.mainSkin.name.Contains("fected");
                if (flag)
                {
                    GameObject gameObject = new GameObject("Line");
                    LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
                    lineRenderer.startWidth = 0.01f;
                    lineRenderer.endWidth = 0.01f;
                    lineRenderer.positionCount = 2;
                    lineRenderer.useWorldSpace = true;
                    lineRenderer.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                    lineRenderer.SetPosition(1, vrrig.transform.position);
                    lineRenderer.material.shader = Shader.Find("GUI/Text Shader");
                    if (Mods.change9 == 1)
                    {
                        lineRenderer.startColor = Color.blue;
                        lineRenderer.endColor = Color.blue;
                    }
                    if (Mods.change9 == 2)
                    {
                        lineRenderer.startColor = Color.red;
                        lineRenderer.endColor = Color.red;
                    }
                    if (Mods.change9 == 3)
                    {
                        lineRenderer.startColor = Color.white;
                        lineRenderer.endColor = Color.white;
                    }
                    if (Mods.change9 == 4)
                    {
                        lineRenderer.startColor = Color.green;
                        lineRenderer.endColor = Color.green;
                    }
                    if (Mods.change9 == 5)
                    {
                        lineRenderer.startColor = Color.magenta;
                        lineRenderer.endColor = Color.magenta;
                    }
                    if (Mods.change9 == 6)
                    {
                        lineRenderer.startColor = Color.cyan;
                        lineRenderer.endColor = Color.cyan;
                    }
                    if (Mods.change9 == 7)
                    {
                        lineRenderer.startColor = Color.yellow;
                        lineRenderer.endColor = Color.yellow;
                    }
                    if (Mods.change9 == 8)
                    {
                        lineRenderer.startColor = Color.black;
                        lineRenderer.endColor = Color.black;
                    }
                    if (Mods.change9 == 9)
                    {
                        lineRenderer.startColor = Color.grey;
                        lineRenderer.endColor = Color.grey;
                    }
                    if (Mods.change9 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        lineRenderer.startColor = color;
                        lineRenderer.endColor = color;
                    }
                    if (Mods.change9 == 11)
                    {
                        lineRenderer.startColor = vrrig.playerColor;
                        lineRenderer.endColor = vrrig.playerColor;
                    }
                    if (Mods.change9 == 12)
                    {
                        if (vrrig.mainSkin.material.name.Contains("fected"))
                        {
                            lineRenderer.startColor = Color.red;
                            lineRenderer.endColor = Color.red;
                        }
                        else
                        {
                            lineRenderer.startColor = Color.green;
                            lineRenderer.endColor = Color.green;
                        }
                    }
                    Object.Destroy(gameObject, Time.deltaTime);
                }
            }
        }
        public static void MosaSpeed()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f;
        }
        public static void MosaSpeedBoost()
        {
            if (Mods.right)
            {
                if (WristMenu.ybuttonDown)
                {
                    GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f;
                }
            }
            else
            {
                if (WristMenu.bbuttonDown)
                {
                    GorillaLocomotion.Player.Instance.maxJumpSpeed = 8f;
                }
            }
        }
        public static void Speed()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 16f;
        }
        public static void GrabBug()
        {
            if (WristMenu.gripDownR)
            {
                GameObject.Find("Floating Bug Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
            if (WristMenu.gripDownL)
            {
                GameObject.Find("Floating Bug Holdable").transform.position = GorillaTagger.Instance.leftHandTransform.position;
            }
        }
        public static void Buggun()
        {
            if (WristMenu.gripDownR)
            {
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitInfo);
                if (Mods.change17 == 1)
                {
                    Mods.pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    Mods.pointer.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                    Mods.pointer.transform.position = hitInfo.point;
                }
                if (Mods.change17 == 2)
                {
                    Mods.pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    Object.Destroy(Mods.pointer.GetComponent<Renderer>());
                    Mods.pointer.transform.position = hitInfo.point;
                    GameObject gameObject2 = new GameObject("Line");
                    Mods.Line = gameObject2.AddComponent<LineRenderer>();
                    Mods.Line.material.shader = Shader.Find("GUI/Text Shader");
                    Mods.Line.startWidth = 0.025f;
                    Mods.Line.endWidth = 0.025f;
                    if (Mods.change8 == 1)
                    {
                        Mods.Line.startColor = Color.blue;
                        Mods.Line.endColor = Color.blue;
                    }
                    if (Mods.change8 == 2)
                    {
                        Mods.Line.startColor = Color.red;
                        Mods.Line.endColor = Color.red;
                    }
                    if (Mods.change8 == 3)
                    {
                        Mods.Line.startColor = Color.white;
                        Mods.Line.endColor = Color.white;
                    }
                    if (Mods.change8 == 4)
                    {
                        Mods.Line.startColor = Color.green;
                        Mods.Line.endColor = Color.green;
                    }
                    if (Mods.change8 == 5)
                    {
                        Mods.Line.startColor = Color.magenta;
                        Mods.Line.endColor = Color.magenta;
                    }
                    if (Mods.change8 == 6)
                    {
                        Mods.Line.startColor = Color.cyan;
                        Mods.Line.endColor = Color.cyan;
                    }
                    if (Mods.change8 == 7)
                    {
                        Mods.Line.startColor = Color.yellow;
                        Mods.Line.endColor = Color.yellow;
                    }
                    if (Mods.change8 == 8)
                    {
                        Mods.Line.startColor = Color.black;
                        Mods.Line.endColor = Color.black;
                    }
                    if (Mods.change8 == 9)
                    {
                        Mods.Line.startColor = Color.grey;
                        Mods.Line.endColor = Color.grey;
                    }
                    if (Mods.change8 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        Mods.Line.startColor = color;
                        Mods.Line.endColor = color;
                    }
                    Mods.Line.positionCount = 2;
                    Mods.Line.useWorldSpace = true;
                    Mods.Line.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                    Mods.Line.SetPosition(1, Mods.pointer.transform.position);
                    Object.Destroy(gameObject2, Time.deltaTime);
                }
                if (Mods.change8 == 1)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (Mods.change8 == 2)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.red;
                }
                if (Mods.change8 == 3)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.white;
                }
                if (Mods.change8 == 4)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.green;
                }
                if (Mods.change8 == 5)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.magenta;
                }
                if (Mods.change8 == 6)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.cyan;
                }
                if (Mods.change8 == 7)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.yellow;
                }
                if (Mods.change8 == 8)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
                }
                if (Mods.change8 == 9)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.grey;
                }
                if (Mods.change8 == 10)
                {
                    GradientColorKey[] array = new GradientColorKey[7];
                    array[0].color = Color.red;
                    array[0].time = 0f;
                    array[1].color = Color.yellow;
                    array[1].time = 0.2f;
                    array[2].color = Color.green;
                    array[2].time = 0.3f;
                    array[3].color = Color.cyan;
                    array[3].time = 0.5f;
                    array[4].color = Color.blue;
                    array[4].time = 0.6f;
                    array[5].color = Color.magenta;
                    array[5].time = 0.8f;
                    array[6].color = Color.red;
                    array[6].time = 1f;
                    Gradient gradient = new Gradient();
                    gradient.colorKeys = array;
                    float num = Mathf.PingPong(Time.time / 2f, 1f);
                    Color color = gradient.Evaluate(num);
                    Mods.pointer.GetComponent<Renderer>().material.color = color;
                }
                GameObject.Destroy(Mods.pointer.GetComponent<BoxCollider>());
                GameObject.Destroy(Mods.pointer.GetComponent<Rigidbody>());
                GameObject.Destroy(Mods.pointer.GetComponent<Collider>());
                if (WristMenu.triggerDownR)
                {
                    GameObject.Find("Floating Bug Holdable").transform.position = Mods.pointer.transform.position + new Vector3(0f, 0.2f, 0f);
                }
            }
            if (Mods.pointer != null)
            {
                GameObject.Destroy(Mods.pointer, Time.deltaTime);
            }
        }
        public static void BugOrbit()
        {
            bool activeSelf = GameObject.Find("Floating Bug Holdable").activeSelf;
            if (activeSelf)
            {
                GameObject gameObject = GameObject.Find("Floating Bug Holdable");
                Transform transform = GorillaLocomotion.Player.Instance.bodyCollider.transform;
                float num = 3f;
                float num2 = 0.9f;
                Vector3 position = gameObject.transform.position;
                bool flag = transform == null;
                if (flag)
                {
                    transform = GorillaTagger.Instance.bodyCollider.transform;
                }
                float num3 = Time.time * num;
                Vector3 vector = new Vector3(Mathf.Cos(num3), 0f, Mathf.Sin(num3)) * num2;
                gameObject.transform.position = transform.position + vector;
                Vector3 position2 = gameObject.transform.position;
                position2.y = position.y;
                gameObject.transform.position = position2;
                GameObject gameObject2 = GameObject.Find("Floating Bug Holdable");
                bool flag2 = gameObject2 != null;
                if (flag2)
                {
                    Vector3 position3 = gameObject2.transform.position;
                    position3.y = GorillaLocomotion.Player.Instance.bodyCollider.transform.position.y;
                    gameObject2.transform.position = position3;
                }
            }
            GameObject gameObject3 = GameObject.Find("Floating Bug Holdable");
            bool flag3 = gameObject3 != null;
            if (flag3)
            {
                Vector3 position4 = gameObject3.transform.position;
                position4.y = GorillaLocomotion.Player.Instance.bodyCollider.transform.position.y;
                gameObject3.transform.position = position4;
            }
        }
        public static void Batgun()
        {
            if (WristMenu.gripDownR)
            {
                Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position, -GorillaLocomotion.Player.Instance.rightControllerTransform.up, out var hitInfo);
                if (Mods.change17 == 1)
                {
                    Mods.pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    Mods.pointer.GetComponent<Renderer>().material.shader = Shader.Find("GorillaTag/UberShader");
                    Mods.pointer.transform.position = hitInfo.point;
                }
                if (Mods.change17 == 2)
                {
                    Mods.pointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    Mods.pointer.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
                    Object.Destroy(Mods.pointer.GetComponent<Renderer>());
                    Mods.pointer.transform.position = hitInfo.point;
                    GameObject gameObject2 = new GameObject("Line");
                    Mods.Line = gameObject2.AddComponent<LineRenderer>();
                    Mods.Line.material.shader = Shader.Find("GUI/Text Shader");
                    Mods.Line.startWidth = 0.025f;
                    Mods.Line.endWidth = 0.025f;
                    if (Mods.change8 == 1)
                    {
                        Mods.Line.startColor = Color.blue;
                        Mods.Line.endColor = Color.blue;
                    }
                    if (Mods.change8 == 2)
                    {
                        Mods.Line.startColor = Color.red;
                        Mods.Line.endColor = Color.red;
                    }
                    if (Mods.change8 == 3)
                    {
                        Mods.Line.startColor = Color.white;
                        Mods.Line.endColor = Color.white;
                    }
                    if (Mods.change8 == 4)
                    {
                        Mods.Line.startColor = Color.green;
                        Mods.Line.endColor = Color.green;
                    }
                    if (Mods.change8 == 5)
                    {
                        Mods.Line.startColor = Color.magenta;
                        Mods.Line.endColor = Color.magenta;
                    }
                    if (Mods.change8 == 6)
                    {
                        Mods.Line.startColor = Color.cyan;
                        Mods.Line.endColor = Color.cyan;
                    }
                    if (Mods.change8 == 7)
                    {
                        Mods.Line.startColor = Color.yellow;
                        Mods.Line.endColor = Color.yellow;
                    }
                    if (Mods.change8 == 8)
                    {
                        Mods.Line.startColor = Color.black;
                        Mods.Line.endColor = Color.black;
                    }
                    if (Mods.change8 == 9)
                    {
                        Mods.Line.startColor = Color.grey;
                        Mods.Line.endColor = Color.grey;
                    }
                    if (Mods.change8 == 10)
                    {
                        GradientColorKey[] array = new GradientColorKey[7];
                        array[0].color = Color.red;
                        array[0].time = 0f;
                        array[1].color = Color.yellow;
                        array[1].time = 0.2f;
                        array[2].color = Color.green;
                        array[2].time = 0.3f;
                        array[3].color = Color.cyan;
                        array[3].time = 0.5f;
                        array[4].color = Color.blue;
                        array[4].time = 0.6f;
                        array[5].color = Color.magenta;
                        array[5].time = 0.8f;
                        array[6].color = Color.red;
                        array[6].time = 1f;
                        Gradient gradient = new Gradient();
                        gradient.colorKeys = array;
                        float num = Mathf.PingPong(Time.time / 2f, 1f);
                        Color color = gradient.Evaluate(num);
                        Mods.Line.startColor = color;
                        Mods.Line.endColor = color;
                    }
                    Mods.Line.positionCount = 2;
                    Mods.Line.useWorldSpace = true;
                    Mods.Line.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                    Mods.Line.SetPosition(1, Mods.pointer.transform.position);
                    Object.Destroy(gameObject2, Time.deltaTime);
                }
                if (Mods.change8 == 1)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.blue;
                }
                if (Mods.change8 == 2)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.red;
                }
                if (Mods.change8 == 3)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.white;
                }
                if (Mods.change8 == 4)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.green;
                }
                if (Mods.change8 == 5)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.magenta;
                }
                if (Mods.change8 == 6)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.cyan;
                }
                if (Mods.change8 == 7)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.yellow;
                }
                if (Mods.change8 == 8)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.black;
                }
                if (Mods.change8 == 9)
                {
                    Mods.pointer.GetComponent<Renderer>().material.color = Color.grey;
                }
                if (Mods.change8 == 10)
                {
                    GradientColorKey[] array = new GradientColorKey[7];
                    array[0].color = Color.red;
                    array[0].time = 0f;
                    array[1].color = Color.yellow;
                    array[1].time = 0.2f;
                    array[2].color = Color.green;
                    array[2].time = 0.3f;
                    array[3].color = Color.cyan;
                    array[3].time = 0.5f;
                    array[4].color = Color.blue;
                    array[4].time = 0.6f;
                    array[5].color = Color.magenta;
                    array[5].time = 0.8f;
                    array[6].color = Color.red;
                    array[6].time = 1f;
                    Gradient gradient = new Gradient();
                    gradient.colorKeys = array;
                    float num = Mathf.PingPong(Time.time / 2f, 1f);
                    Color color = gradient.Evaluate(num);
                    Mods.pointer.GetComponent<Renderer>().material.color = color;
                }
                GameObject.Destroy(Mods.pointer.GetComponent<BoxCollider>());
                GameObject.Destroy(Mods.pointer.GetComponent<Rigidbody>());
                GameObject.Destroy(Mods.pointer.GetComponent<Collider>());
                if (WristMenu.triggerDownR)
                {
                    GameObject.Find("Cave Bat Holdable").transform.position = Mods.pointer.transform.position + new Vector3(0f, 0.2f, 0f);
                }
            }
            if (Mods.pointer != null)
            {
                GameObject.Destroy(Mods.pointer, Time.deltaTime);
            }
        }
        public static void GrabBat()
        {
            if (WristMenu.gripDownR)
            {
                GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.rightHandTransform.position;
            }
            if (WristMenu.gripDownL)
            {
                GameObject.Find("Cave Bat Holdable").transform.position = GorillaTagger.Instance.leftHandTransform.position;
            }
        }
        public static void BatOrbit()
        {
            bool activeSelf = GameObject.Find("Cave Bat Holdable").activeSelf;
            if (activeSelf)
            {
                GameObject gameObject = GameObject.Find("Cave Bat Holdable");
                Transform transform = GorillaLocomotion.Player.Instance.bodyCollider.transform;
                float num = 3f;
                float num2 = 0.9f;
                Vector3 position = gameObject.transform.position;
                bool flag = transform == null;
                if (flag)
                {
                    transform = GorillaTagger.Instance.bodyCollider.transform;
                }
                float num3 = Time.time * num;
                Vector3 vector = new Vector3(Mathf.Cos(num3), 0f, Mathf.Sin(num3)) * num2;
                gameObject.transform.position = transform.position + vector;
                Vector3 position2 = gameObject.transform.position;
                position2.y = position.y;
                gameObject.transform.position = position2;
                GameObject gameObject2 = GameObject.Find("Cave Bat Holdable");
                bool flag2 = gameObject2 != null;
                if (flag2)
                {
                    Vector3 position3 = gameObject2.transform.position;
                    position3.y = GorillaLocomotion.Player.Instance.bodyCollider.transform.position.y;
                    gameObject2.transform.position = position3;
                }
            }
            GameObject gameObject3 = GameObject.Find("Cave Bat Holdable");
            bool flag3 = gameObject3 != null;
            if (flag3)
            {
                Vector3 position4 = gameObject3.transform.position;
                position4.y = GorillaLocomotion.Player.Instance.bodyCollider.transform.position.y;
                gameObject3.transform.position = position4;
            }
        }
        public static void Beacons()
        {
            bool flag = PhotonNetwork.CurrentRoom != null;
            if (flag)
            {
                foreach (Player player in PhotonNetwork.PlayerListOthers)
                {
                    PhotonView photonView = GorillaGameManager.instance.FindVRRigForPlayer(player);
                    VRRig vrrig = GorillaGameManager.instance.FindPlayerVRRig(player);
                    bool flag2 = !vrrig.isOfflineVRRig && !vrrig.isMyPlayer && !photonView.IsMine;
                    if (flag2)
                    {
                        GameObject gameObject = GameObject.CreatePrimitive((PrimitiveType)2);
                        Object.Destroy(gameObject.GetComponent<BoxCollider>());
                        Object.Destroy(gameObject.GetComponent<Rigidbody>());
                        Object.Destroy(gameObject.GetComponent<Collider>());
                        gameObject.transform.rotation = Quaternion.identity;
                        gameObject.transform.localScale = new Vector3(0.04f, 200f, 0.04f);
                        gameObject.transform.position = vrrig.transform.position;
                        gameObject.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                        if (Mods.change9 == 1)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.blue;
                        }
                        if (Mods.change9 == 2)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.red;
                        }
                        if (Mods.change9 == 3)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.white;
                        }
                        if (Mods.change9 == 4)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.green;
                        }
                        if (Mods.change9 == 5)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
                        }
                        if (Mods.change9 == 6)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                        }
                        if (Mods.change9 == 7)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
                        }
                        if (Mods.change9 == 8)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.black;
                        }
                        if (Mods.change9 == 9)
                        {
                            gameObject.GetComponent<Renderer>().material.color = Color.grey;
                        }
                        if (Mods.change9 == 10)
                        {
                            GradientColorKey[] array = new GradientColorKey[7];
                            array[0].color = Color.red;
                            array[0].time = 0f;
                            array[1].color = Color.yellow;
                            array[1].time = 0.2f;
                            array[2].color = Color.green;
                            array[2].time = 0.3f;
                            array[3].color = Color.cyan;
                            array[3].time = 0.5f;
                            array[4].color = Color.blue;
                            array[4].time = 0.6f;
                            array[5].color = Color.magenta;
                            array[5].time = 0.8f;
                            array[6].color = Color.red;
                            array[6].time = 1f;
                            Gradient gradient = new Gradient();
                            gradient.colorKeys = array;
                            float num = Mathf.PingPong(Time.time / 2f, 1f);
                            Color color = gradient.Evaluate(num);
                            gameObject.GetComponent<MeshRenderer>().material.color = color;
                        }
                        if (Mods.change9 == 11)
                        {
                            gameObject.GetComponent<Renderer>().material.color = vrrig.playerColor;
                        }
                        if (Mods.change9 == 12)
                        {
                            if (vrrig.mainSkin.material.name.Contains("fected"))
                            {
                                gameObject.GetComponent<Renderer>().material.color = Color.red;
                            }
                            else
                            {
                                gameObject.GetComponent<Renderer>().material.color = Color.green;
                            }
                        }
                        Object.Destroy(gameObject, Time.deltaTime);
                    }
                }
            }
        }
        public static void Save1()
        {
            WristMenu.buttons[0].enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
            List<string> list = new List<string>();
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons1)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons2)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons3)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons4)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons5)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons6)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons7)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.CatButtons8)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            foreach (ButtonInfo buttonInfo in WristMenu.Favbuttons)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            File.WriteAllLines("Malachis_Temp\\Saved_Buttons.txt", list);
            NotifiLib.SendNotification("<color=white>[</color><color=blue>SAVE</color><color=white>]</color> <color=white>Saved buttons successfully!</color>");
            Mods.GetButton("Save Buttons").enabled = new bool?(false);
        }
        public static void Load1()
        {
            string[] array = File.ReadAllLines("Malachis_Temp\\Saved_Buttons.txt");
            foreach (string b in array)
            {
                foreach (ButtonInfo buttonInfo in WristMenu.Favbuttons)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons1)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons2)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons3)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons4)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons5)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons6)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons7)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
                foreach (ButtonInfo buttonInfo in WristMenu.CatButtons8)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
            }
            NotifiLib.SendNotification("<color=white>[</color><color=blue>LOAD</color><color=white>]</color> <color=white>Loaded buttons successfully!</color>");
            Mods.GetButton("Load Buttons").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void LoadFavs()
        {
            // this stuff dont work
            if (File.Exists("Malachis_Temp\\Saved_Fav_Mods.txt") && !Mods.FavBool)
            {
                foreach (string name in System.IO.File.ReadAllLines("Malachis_Temp\\Saved_Fav_Mods.txt"))
                {
                    WristMenu.Favbuttons.Add(GetButton(name));
                }
                Mods.FavBool = true;
            }
            Mods.GetButton("Load Favs").enabled = false;
            WristMenu.Favbuttons[0].enabled = false;
            Mods.inFav = !Mods.inFav;
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Save()
        {
            WristMenu.settingsbuttons[1].enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
            List<string> list = new List<string>();
            foreach (ButtonInfo buttonInfo in WristMenu.settingsbuttons)
            {
                bool? enabled = buttonInfo.enabled;
                bool flag = true;
                bool flag2 = enabled.GetValueOrDefault() == flag & enabled != null;
                if (flag2)
                {
                    list.Add(buttonInfo.buttonText);
                }
            }
            Directory.CreateDirectory("Malachis_Temp");
            File.WriteAllLines("Malachis_Temp\\Saved_Settings.txt", list);
            string text4 = string.Concat(new string[]
            {
               Mods.change1.ToString(),
               "\n",
               Mods.change2.ToString(),
               "\n",
               Mods.change3.ToString(),
               "\n",
               Mods.change4.ToString(),
               "\n",
               Mods.change5.ToString(),
               "\n",
               Mods.change6.ToString(),
               "\n",
               Mods.change7.ToString(),
               "\n",
               Mods.change8.ToString(),
               "\n",
               Mods.change9.ToString(),
               "\n",
               Mods.change10.ToString(),
               "\n",
               Mods.change11.ToString(),
               "\n",
               Mods.change12.ToString(),
               "\n",
               Mods.change13.ToString(),
               "\n",
               Mods.change14.ToString(),
               "\n",
               Mods.change15.ToString(),
               "\n",
               Mods.change16.ToString(),
               "\n",
               Mods.change17.ToString()
            });
            File.WriteAllText("Malachis_Temp/Saved_Settings2.txt", text4.ToString());
            NotifiLib.SendNotification("<color=white>[</color><color=blue>SAVE</color><color=white>]</color> <color=white>Saved settings successfully!</color>");
        }
        public static void Load()
        {
            string[] array = File.ReadAllLines("Malachis_Temp\\Saved_Settings.txt");
            foreach (string b in array)
            {
                foreach (ButtonInfo buttonInfo in WristMenu.settingsbuttons)
                {
                    bool flag = buttonInfo.buttonText == b;
                    if (flag)
                    {
                        buttonInfo.enabled = new bool?(true);
                    }
                }
            }
            try
            {
                string text3 = File.ReadAllText("Malachis_Temp/Saved_Settings2.txt");
                string[] array4 = text3.Split(new string[] { "\n" }, StringSplitOptions.None);
                Mods.change1 = int.Parse(array4[0]) - 1;
                Mods.Changeplat();
                Mods.change2 = int.Parse(array4[1]) - 1;
                Mods.Changenoti();
                Mods.change3 = int.Parse(array4[2]) - 1;
                Mods.ChangeFPS();
                Mods.change4 = int.Parse(array4[3]) - 1;
                Mods.Changedisconnect();
                Mods.change5 = int.Parse(array4[4]) - 1;
                Mods.Changefly();
                Mods.change6 = int.Parse(array4[5]) - 1;
                Mods.Changemenu();
                Mods.change7 = int.Parse(array4[6]) - 1;
                Mods.Changepagebutton();
                Mods.change8 = int.Parse(array4[7]) - 1;
                Mods.ChangeOrbColor();
                Mods.change9 = int.Parse(array4[8]) - 1;
                Mods.ChangeVisualColor();
                Mods.change10 = int.Parse(array4[9]) - 1;
                Mods.ThemeChangerV1();
                Mods.change11 = int.Parse(array4[10]) - 1;
                Mods.ThemeChangerV2();
                Mods.change12 = int.Parse(array4[11]) - 1;
                Mods.ThemeChangerV3();
                Mods.change13 = int.Parse(array4[12]) - 1;
                Mods.ThemeChangerV4();
                Mods.change14 = int.Parse(array4[13]) - 1;
                Mods.ThemeChangerV5();
                Mods.change15 = int.Parse(array4[14]) - 1;
                Mods.ThemeChangerV6();
                Mods.change16 = int.Parse(array4[15]) - 1;
                Mods.ThemeChangerV7();
                Mods.change17 = int.Parse(array4[16]) - 1;
                Mods.ChangeGunType();
            }
            catch
            {
            }
            NotifiLib.SendNotification("<color=white>[</color><color=blue>LOAD</color><color=white>]</color> <color=white>Loaded settings successfully!</color>");
            Mods.GetButton("Load Settings").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }

        private static void PlatformsThing(bool invis, bool sticky)
        {
            if (Mods.change1 == 1)
            {
                bool gripDownR2 = WristMenu.gripDownR;
                bool gripDownL2 = WristMenu.gripDownL;
                bool flag9 = gripDownR2;
                if (flag9)
                {
                    bool flag2 = !Mods.once_right && Mods.jump_right_local == null;
                    if (flag2)
                    {
                        if (sticky)
                        {
                            Mods.jump_right_local = GameObject.CreatePrimitive(0);
                        }
                        else
                        {
                            Mods.jump_right_local = GameObject.CreatePrimitive((PrimitiveType)3);
                        }
                        if (invis)
                        {
                            Object.Destroy(Mods.jump_right_local.GetComponent<Renderer>());
                        }
                        Mods.jump_right_local.transform.localScale = Mods.scale;
                        Mods.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                        Mods.jump_right_local.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                        object[] array1 = new object[]
                        {
                        new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.rightControllerTransform.position,
                        GorillaLocomotion.Player.Instance.rightControllerTransform.rotation
                        };
                        RaiseEventOptions raiseEventOptions1 = new RaiseEventOptions
                        {
                            Receivers = 0
                        };
                        PhotonNetwork.RaiseEvent(70, array1, raiseEventOptions1, SendOptions.SendReliable);
                        Mods.once_right = true;
                        Mods.once_right_false = false;
                        ColorChanger colorChanger1 = Mods.jump_right_local.AddComponent<ColorChanger>();
                        colorChanger1.colors = new Gradient
                        {
                            colorKeys = Mods.colorKeysPlatformMonke
                        };
                        colorChanger1.Start();
                    }
                }
                else
                {
                    bool flag3 = !Mods.once_right_false && Mods.jump_right_local != null;
                    if (flag3)
                    {
                        GameObject.Destroy(Mods.jump_right_local.GetComponent<Collider>());
                        Rigidbody platr = Mods.jump_right_local.AddComponent(typeof(Rigidbody)) as Rigidbody;
                        platr.velocity = GorillaLocomotion.Player.Instance.rightHandCenterVelocityTracker.GetAverageVelocity(true, 5);
                        UnityEngine.Object.Destroy(jump_right_local, 2.0f);
                        jump_right_local = null;
                        once_right = false;
                        once_right_false = true;
                        RaiseEventOptions raiseEventOptions2 = new RaiseEventOptions
                        {
                            Receivers = ReceiverGroup.Others
                        };
                        PhotonNetwork.RaiseEvent(72, null, raiseEventOptions2, SendOptions.SendReliable);
                    }
                }
                bool flag10 = gripDownL2;
                if (flag10)
                {
                    bool flag5 = !Mods.once_left && Mods.jump_left_local == null;
                    if (flag5)
                    {
                        if (sticky)
                        {
                            Mods.jump_left_local = GameObject.CreatePrimitive(0);
                        }
                        else
                        {
                            Mods.jump_left_local = GameObject.CreatePrimitive((PrimitiveType)3);
                        }
                        if (invis)
                        {
                            Object.Destroy(Mods.jump_left_local.GetComponent<Renderer>());
                        }
                        Mods.jump_left_local.transform.localScale = Mods.scale;
                        Mods.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                        Mods.jump_left_local.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                        object[] array2 = new object[]
                        {
                        new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.leftControllerTransform.position,
                        GorillaLocomotion.Player.Instance.leftControllerTransform.rotation
                        };
                        RaiseEventOptions raiseEventOptions3 = new RaiseEventOptions
                        {
                            Receivers = 0
                        };
                        PhotonNetwork.RaiseEvent(69, array2, raiseEventOptions3, SendOptions.SendReliable);
                        Mods.once_left = true;
                        Mods.once_left_false = false;
                        ColorChanger colorChanger2 = Mods.jump_left_local.AddComponent<ColorChanger>();
                        colorChanger2.colors = new Gradient
                        {
                            colorKeys = Mods.colorKeysPlatformMonke
                        };
                        colorChanger2.Start();
                    }
                }
                else
                {
                    bool flag6 = !Mods.once_left_false && Mods.jump_left_local != null;
                    if (flag6)
                    {
                        GameObject.Destroy(Mods.jump_left_local.GetComponent<Collider>());
                        Rigidbody comp = Mods.jump_left_local.AddComponent(typeof(Rigidbody)) as Rigidbody;
                        comp.velocity = GorillaLocomotion.Player.Instance.leftHandCenterVelocityTracker.GetAverageVelocity(true, 5);
                        UnityEngine.Object.Destroy(jump_left_local, 2.0f);
                        jump_left_local = null;
                        once_left = false;
                        once_left_false = true;
                        RaiseEventOptions raiseEventOptions4 = new RaiseEventOptions
                        {
                            Receivers = ReceiverGroup.Others
                        };
                        PhotonNetwork.RaiseEvent(71, null, raiseEventOptions4, SendOptions.SendReliable);
                    }
                }
                bool flag11 = !PhotonNetwork.InRoom;
                if (flag11)
                {
                    for (int i = 0; i < Mods.jump_right_network.Length; i++)
                    {
                        Object.Destroy(Mods.jump_right_network[i]);
                    }
                    for (int j = 0; j < Mods.jump_left_network.Length; j++)
                    {
                        Object.Destroy(Mods.jump_left_network[j]);
                    }
                }
            }
            if (Mods.change1 == 2)
            {
                if (WristMenu.triggerDownR)
                {
                    bool flag84 = !Mods.once_right && Mods.jump_right_local == null;
                    if (flag84)
                    {
                        if (sticky)
                        {
                            Mods.jump_right_local = GameObject.CreatePrimitive(0);
                        }
                        else
                        {
                            Mods.jump_right_local = GameObject.CreatePrimitive((PrimitiveType)3);
                        }
                        if (invis)
                        {
                            Object.Destroy(Mods.jump_right_local.GetComponent<Renderer>());
                        }
                        Mods.jump_right_local.transform.localScale = Mods.scale;
                        Mods.jump_right_local.transform.position = new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                        Mods.jump_right_local.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                        object[] array7 = new object[]
                        {
                        new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.rightControllerTransform.position,
                        GorillaLocomotion.Player.Instance.rightControllerTransform.rotation
                        };
                        RaiseEventOptions raiseEventOptions7 = new RaiseEventOptions
                        {
                            Receivers = 0
                        };
                        PhotonNetwork.RaiseEvent(70, array7, raiseEventOptions7, SendOptions.SendReliable);
                        Mods.once_right = true;
                        Mods.once_right_false = false;
                        ColorChanger colorChanger9 = Mods.jump_right_local.AddComponent<ColorChanger>();
                        colorChanger9.colors = new Gradient
                        {
                            colorKeys = Mods.colorKeysPlatformMonke
                        };
                        colorChanger9.Start();
                    }
                }
                else
                {
                    bool flag92 = !Mods.once_right_false && Mods.jump_right_local != null;
                    if (flag92)
                    {
                        Rigidbody platr = Mods.jump_right_local.AddComponent(typeof(Rigidbody)) as Rigidbody;
                        platr.velocity = GorillaLocomotion.Player.Instance.rightHandCenterVelocityTracker.GetAverageVelocity(true, 5);
                        UnityEngine.Object.Destroy(jump_right_local, 2.0f);
                        jump_right_local = null;
                        once_right = false;
                        once_right_false = true;
                        RaiseEventOptions raiseEventOptions2 = new RaiseEventOptions
                        {
                            Receivers = ReceiverGroup.Others
                        };
                        PhotonNetwork.RaiseEvent(72, null, raiseEventOptions2, SendOptions.SendReliable);
                    }
                }
                if (WristMenu.triggerDownL)
                {
                    bool flag73 = !Mods.once_left && Mods.jump_left_local == null;
                    if (flag73)
                    {
                        if (sticky)
                        {
                            Mods.jump_left_local = GameObject.CreatePrimitive(0);
                        }
                        else
                        {
                            Mods.jump_left_local = GameObject.CreatePrimitive((PrimitiveType)3);
                        }
                        if (invis)
                        {
                            Object.Destroy(Mods.jump_left_local.GetComponent<Renderer>());
                        }
                        Mods.jump_left_local.transform.localScale = Mods.scale;
                        Mods.jump_left_local.transform.position = new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                        Mods.jump_left_local.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                        object[] array0 = new object[]
                        {
                        new Vector3(0f, -0.01f, 0f) + GorillaLocomotion.Player.Instance.leftControllerTransform.position,
                        GorillaLocomotion.Player.Instance.leftControllerTransform.rotation
                        };
                        RaiseEventOptions raiseEventOptions0 = new RaiseEventOptions
                        {
                            Receivers = 0
                        };
                        PhotonNetwork.RaiseEvent(69, array0, raiseEventOptions0, SendOptions.SendReliable);
                        Mods.once_left = true;
                        Mods.once_left_false = false;
                        ColorChanger colorChanger0 = Mods.jump_left_local.AddComponent<ColorChanger>();
                        colorChanger0.colors = new Gradient
                        {
                            colorKeys = Mods.colorKeysPlatformMonke
                        };
                        colorChanger0.Start();
                    }
                }
                else
                {
                    bool flag283 = !Mods.once_left_false && Mods.jump_left_local != null;
                    if (flag283)
                    {
                        Rigidbody comp = Mods.jump_left_local.AddComponent(typeof(Rigidbody)) as Rigidbody;
                        comp.velocity = GorillaLocomotion.Player.Instance.leftHandCenterVelocityTracker.GetAverageVelocity(true, 5);
                        UnityEngine.Object.Destroy(jump_left_local, 2.0f);
                        jump_left_local = null;
                        once_left = false;
                        once_left_false = true;
                        RaiseEventOptions raiseEventOptions4 = new RaiseEventOptions
                        {
                            Receivers = ReceiverGroup.Others
                        };
                        PhotonNetwork.RaiseEvent(71, null, raiseEventOptions4, SendOptions.SendReliable);
                    }
                }
                bool flag13 = !PhotonNetwork.InRoom;
                if (flag13)
                {
                    for (int i = 0; i < Mods.jump_right_network.Length; i++)
                    {
                        Object.Destroy(Mods.jump_right_network[i]);
                    }
                    for (int j = 0; j < Mods.jump_left_network.Length; j++)
                    {
                        Object.Destroy(Mods.jump_left_network[j]);
                    }
                }
            }
        }
        public static ButtonInfo GetButton(string name)
        {
            foreach (ButtonInfo buttonInfo1 in WristMenu.buttons)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.settingsbuttons)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons1)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.Favbuttons)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons2)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons3)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons4)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons5)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons6)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons7)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            foreach (ButtonInfo buttonInfo1 in WristMenu.CatButtons8)
            {
                if (buttonInfo1.buttonText == name)
                {
                    return buttonInfo1;
                }
            }
            return null;
        }
        public static void Settings()
        {
            WristMenu.settingsbuttons[0].enabled = new bool?(false);
            WristMenu.buttons[2].enabled = new bool?(false);
            Mods.inSettings = !Mods.inSettings;
            if (Mods.inSettings)
            {
                WristMenu.pageNumber = 0;
            }
            if (!Mods.inSettings)
            {
                WristMenu.pageNumber = 0;
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void FavMods()
        {
            WristMenu.Favbuttons[0].enabled = new bool?(false);
            WristMenu.buttons[3].enabled = new bool?(false);
            Mods.inFav = !Mods.inFav;
            if (Mods.inFav)
            {
                WristMenu.pageNumber = 0;
            }
            if (!Mods.inFav)
            {
                WristMenu.pageNumber = 0;
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat1()
        {
            WristMenu.CatButtons1[0].enabled = new bool?(false);
            WristMenu.buttons[4].enabled = new bool?(false);
            Mods.inCat1 = !Mods.inCat1;
            if (Mods.inCat1)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat1)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat1)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat1)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat1)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat1)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat2()
        {
            WristMenu.CatButtons2[0].enabled = new bool?(false);
            WristMenu.buttons[5].enabled = new bool?(false);
            Mods.inCat2 = !Mods.inCat2;
            if (Mods.inCat2)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat2)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat2)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat2)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat2)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat2)
                {
                    WristMenu.pageNumber = 0;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat3()
        {
            WristMenu.CatButtons3[0].enabled = new bool?(false);
            WristMenu.buttons[6].enabled = new bool?(false);
            Mods.inCat3 = !Mods.inCat3;
            if (Mods.inCat3)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat3)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat3)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat3)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat3)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat3)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat4()
        {
            WristMenu.CatButtons4[0].enabled = new bool?(false);
            WristMenu.buttons[7].enabled = new bool?(false);
            Mods.inCat4 = !Mods.inCat4;
            if (Mods.inCat4)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat4)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat4)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat4)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat4)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat4)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat5()
        {
            WristMenu.CatButtons5[0].enabled = new bool?(false);
            WristMenu.buttons[8].enabled = new bool?(false);
            Mods.inCat5 = !Mods.inCat5;
            if (Mods.inCat5)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat5)
                {
                    WristMenu.pageNumber = 2;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat5)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat5)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat5)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat5)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat6()
        {
            WristMenu.CatButtons6[0].enabled = new bool?(false);
            WristMenu.buttons[9].enabled = new bool?(false);
            Mods.inCat6 = !Mods.inCat6;
            if (Mods.inCat6)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat6)
                {
                    WristMenu.pageNumber = 2;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat6)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat6)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat6)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat6)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat7()
        {
            WristMenu.CatButtons7[0].enabled = new bool?(false);
            WristMenu.buttons[10].enabled = new bool?(false);
            Mods.inCat7 = !Mods.inCat7;
            if (Mods.inCat7)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat7)
                {
                    WristMenu.pageNumber = 2;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat7)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat7)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat7)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat7)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Cat8()
        {
            WristMenu.CatButtons8[0].enabled = new bool?(false);
            WristMenu.buttons[11].enabled = new bool?(false);
            Mods.inCat8 = !Mods.inCat8;
            if (Mods.inCat8)
            {
                WristMenu.pageNumber = 0;
            }
            if (change7 == 1)
            {
                if (!Mods.inCat8)
                {
                    WristMenu.pageNumber = 2;
                }
            }
            if (change7 == 2)
            {
                if (!Mods.inCat8)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 3)
            {
                if (!Mods.inCat8)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 4)
            {
                if (!Mods.inCat8)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            if (change7 == 5)
            {
                if (!Mods.inCat8)
                {
                    WristMenu.pageNumber = 1;
                }
            }
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void one()
        {
            Mods.longArms = true;
        }
        public static void two()
        {
            Mods.longerarms = true;
        }
        public static void three()
        {
            Mods.longlongarms = true;
        }
        public static void head1()
        {
            Mods.Head1 = true;
        }
        public static void Head2()
        {
            Mods.head2 = true;
        }
        public static void Head3()
        {
            Mods.head3 = true;
        }
        public static void Headback()
        {
            Mods.headback = true;
        }
        public static void Uphead()
        {
            Mods.downhead = true;
        }
        public static void righthand()
        {
            Mods.right = true;
        }
        public static void GhostMonk()
        {
            Mods.GhostMonkGUI = true;
        }
        public static void InvisMonk()
        {
            Mods.InvisMonkGUI = true;
        }
        public static void rejoin()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(Mods.room);
            Mods.GetButton("Join Last Room").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Fps()
        {
            Mods.fps = true;
        }
        public static void offrighthand()
        {
            if (Mods.right)
            {
                Mods.right = false;
            }
        }
        // DO NOT MESS WITH ANY OF THE TEME CHANGERS OR CHANGERS
        public static void Changeplat()
        {
            Mods.change1++;
            bool flag = Mods.change1 > 2;
            if (flag)
            {
                Mods.change1 = 1;
            }
            bool flag2 = Mods.change1 == 1;
            if (flag2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>PLATFORMS</color><color=white>] Enable Platforms: Grips</color>");
            }
            bool flag3 = Mods.change1 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>PLATFORMS</color><color=white>] Enable Platforms: Triggers</color>");
            }
            Mods.GetButton("Change Platform Enable").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Changenoti()
        {
            Mods.change2++;
            bool flag = Mods.change2 > 2;
            if (flag)
            {
                Mods.change2 = 1;
            }
            bool flag2 = Mods.change2 == 1;
            if (flag2)
            {
                NotifiLib.IsEnabled = true;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NOTIS</color><color=white>] Notis Enabled: Yes</color>");
            }
            bool flag3 = Mods.change2 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NOTIS</color><color=white>] Notis Enabled: No</color>");
                NotifiLib.IsEnabled = false;
            }
            Mods.GetButton("No Notis").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ChangeFPS()
        {
            Mods.change3++;
            bool flag = Mods.change3 > 2;
            if (flag)
            {
                Mods.change3 = 1;
            }
            bool flag2 = Mods.change3 == 1;
            if (flag2)
            {
                Mods.FPSPage = false;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>FPS & PAGE COUNTER</color><color=white>] Is Enabled: No</color>");
            }
            bool flag3 = Mods.change3 == 2;
            if (flag3)
            {
                Mods.FPSPage = true;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>FPS & PAGE COUNTER</color><color=white>] Is Enabled: Yes</color>");
            }
            Mods.GetButton("Toggle FPS & Page Counter").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Changedisconnect()
        {
            Mods.change4++;
            bool flag = Mods.change4 > 4;
            if (flag)
            {
                Mods.change4 = 1;
            }
            bool flag2 = Mods.change4 == 1;
            if (flag2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>DISCONNECT BUTTON</color><color=white>] Disconnect Location: Right Side</color>");
            }
            bool flag3 = Mods.change4 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>DISCONNECT BUTTON</color><color=white>] Disconnect Location: Left Side</color>");
            }
            bool flag4 = Mods.change4 == 3;
            if (flag4)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>DISCONNECT BUTTON</color><color=white>] Disconnect Location: Top</color>");
            }
            bool flag5 = Mods.change4 == 4;
            if (flag5)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>DISCONNECT BUTTON</color><color=white>] Disconnect Location: Bottom</color>");
            }
            Mods.GetButton("Change Disconnect Location").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Changefly()
        {
            Mods.change5++;
            bool flag = Mods.change5 > 3;
            if (flag)
            {
                Mods.change5 = 1;
            }
            bool flag2 = Mods.change5 == 1;
            if (flag2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>FLY GRAV</color><color=white>] Current Gravity: Normal</color>");
            }
            bool flag3 = Mods.change5 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>FLY GRAV</color><color=white>] Current Gravity: Low</color>");
            }
            bool flag4 = Mods.change5 == 3;
            if (flag4)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>FLY GRAV</color><color=white>] Current Gravity: None</color>");
            }
            Mods.GetButton("Change Fly Gravity").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Changemenu()
        {
            Mods.change6++;
            bool flag = Mods.change6 > 2;
            if (flag)
            {
                Mods.change6 = 1;
            }
            bool flag2 = Mods.change6 == 1;
            if (flag2)
            {
                Mods.offrighthand();
                NotifiLib.SendNotification("<color=white>[</color><color=blue>MENU LOCATION</color><color=white>] Current Location: Left Hand</color>");
            }
            bool flag3 = Mods.change6 == 2;
            if (flag3)
            {
                Mods.righthand();
                NotifiLib.SendNotification("<color=white>[</color><color=blue>MENU LOCATION</color><color=white>] Current Location: Right Hand</color>");
            }
            Mods.GetButton("Change Menu Location").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void Changepagebutton()
        {
            Mods.change7++;
            bool flag = Mods.change7 > 5;
            if (flag)
            {
                Mods.change7 = 1;
            }
            bool flag2 = Mods.change7 == 1;
            if (flag2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NEXT & PREV</color><color=white>] Page Change Button Location: On Menu</color>");
            }
            bool flag3 = Mods.change7 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NEXT & PREV</color><color=white>] Page Change Button Location: Top</color>");
            }
            bool flag4 = Mods.change7 == 3;
            if (flag4)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NEXT & PREV</color><color=white>] Page Change Button Location: Sides</color>");
            }
            bool flag5 = Mods.change7 == 4;
            if (flag5)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NEXT & PREV</color><color=white>] Page Change Button Location: Bottom</color>");
            }
            bool flag6 = Mods.change7 == 5;
            if (flag6)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>NEXT & PREV</color><color=white>] Page Change Button Location: Triggers</color>");
            }
            Mods.GetButton("Change Next & Prev").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ChangeOrbColor()
        {
            Mods.change8++;
            bool flag = Mods.change8 > 10;
            if (flag)
            {
                Mods.change8 = 1;
            }
            bool flag2 = Mods.change8 == 1;
            if (flag2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Blue</color>");
            }
            bool flag3 = Mods.change8 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Red</color>");
            }
            bool flag4 = Mods.change8 == 3;
            if (flag4)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: White</color>");
            }
            bool flag5 = Mods.change8 == 4;
            if (flag5)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Green</color>");
            }
            bool flag6 = Mods.change8 == 5;
            if (flag6)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Magenta</color>");
            }
            bool flag7 = Mods.change8 == 6;
            if (flag7)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Cyan</color>");
            }
            bool flag8 = Mods.change8 == 7;
            if (flag8)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Yellow</color>");
            }
            bool flag9 = Mods.change8 == 8;
            if (flag9)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Black</color>");
            }
            bool flag11 = Mods.change8 == 9;
            if (flag11)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: Grey</color>");
            }
            bool flag10 = Mods.change8 == 10;
            if (flag10)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN & HAND ORB COLOR</color><color=white>] Current color: RGB</color>");
            }
            Mods.GetButton("Change Gun & Hand Orb Color").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ChangeVisualColor()
        {
            Mods.change9++;
            bool flag = Mods.change9 > 12;
            if (flag)
            {
                Mods.change9 = 1;
            }
            bool flag2 = Mods.change9 == 1;
            if (flag2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Blue</color>");
            }
            bool flag3 = Mods.change9 == 2;
            if (flag3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Red</color>");
            }
            bool flag4 = Mods.change9 == 3;
            if (flag4)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: White</color>");
            }
            bool flag5 = Mods.change9 == 4;
            if (flag5)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Green</color>");
            }
            bool flag6 = Mods.change9 == 5;
            if (flag6)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Magenta</color>");
            }
            bool flag7 = Mods.change9 == 6;
            if (flag7)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Cyan</color>");
            }
            bool flag8 = Mods.change9 == 7;
            if (flag8)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Yellow</color>");
            }
            bool flag9 = Mods.change9 == 8;
            if (flag9)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Black</color>");
            }
            bool flag13 = Mods.change9 == 9;
            if (flag13)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Grey</color>");
            }
            bool flag10 = Mods.change9 == 10;
            if (flag10)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: RGB</color>");
            }
            bool flag11 = Mods.change9 == 11;
            if (flag11)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Player Color</color>");
            }
            bool flag12 = Mods.change9 == 12;
            if (flag12)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>ESP COLOR</color><color=white>] Current color: Tagged & UnTagged</color>");
            }
            Mods.GetButton("Change ESP Color").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV1()
        {
            Mods.change10++;
            bool flag = Mods.change10 > 11;
            if (flag)
            {
                Mods.change10 = 1;
            }
            bool flag2 = Mods.change10 == 1;
            if (flag2)
            {
                if (WristMenu.ChangingColors)
                {
                    Mods.RGBMenu = false;
                    WristMenu.FirstColor = Color.blue;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Blue</color>");
                }
                else
                {
                    Mods.RGBMenu = false;
                    WristMenu.NormalColor = Color.blue;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Blue</color>");
                }
            }
            bool flag3 = Mods.change10 == 2;
            if (flag3)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.red;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Red</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.red;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Red</color>");
                }
            }
            bool flag4 = Mods.change10 == 3;
            if (flag4)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.white;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: White</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.white;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: White</color>");
                }
            }
            bool flag5 = Mods.change10 == 4;
            if (flag5)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.green;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Green</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.green;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Green</color>");
                }
            }
            bool flag6 = Mods.change10 == 5;
            if (flag6)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.magenta;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Magenta</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.magenta;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Magenta</color>");
                }
            }
            bool flag7 = Mods.change10 == 6;
            if (flag7)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.cyan;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Cyan</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.cyan;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Cyan</color>");
                }
            }
            bool flag8 = Mods.change10 == 7;
            if (flag8)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.yellow;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Yellow</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.yellow;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Yellow</color>");
                }
            }
            bool flag9 = Mods.change10 == 8;
            if (flag9)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.black;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Black</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.black;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Black</color>");
                }
            }
            bool flag10 = Mods.change10 == 9;
            if (flag10)
            {
                if (WristMenu.ChangingColors)
                {
                    WristMenu.FirstColor = Color.grey;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] First Color: Grey</color>");
                }
                else
                {
                    WristMenu.NormalColor = Color.grey;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Grey</color>");
                }
            }
            bool flag11 = Mods.change10 == 10;
            if (flag11)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: Clear</color>");
            }
            bool flag12 = Mods.change10 == 11;
            if (flag12)
            {
                if (WristMenu.ChangingColors)
                {
                    Mods.RGBMenu = true;
                    NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Menu Color: RGB</color>");
                }
                else
                {
                    NotifiLib.SendNotification("<color=white>[</color><color=red>ERROR</color><color=white>] Cannot Change The Menu To RGB Due To WristMenu.ChangingColors Being false</color>");
                }
            }
            Mods.GetButton("Theme ChangerV1").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV2()
        {
            Mods.change11++;
            bool flag = Mods.change11 > 9;
            if (flag)
            {
                Mods.change11 = 1;
            }
            bool flag2 = Mods.change11 == 1;
            if (flag2)
            {
                WristMenu.SecondColor = Color.black;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Black</color>");
            }
            bool flag3 = Mods.change11 == 2;
            if (flag3)
            {
                WristMenu.SecondColor = Color.red;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Red</color>");
            }
            bool flag4 = Mods.change11 == 3;
            if (flag4)
            {
                WristMenu.SecondColor = Color.white;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: White</color>");
            }
            bool flag5 = Mods.change11 == 4;
            if (flag5)
            {
                WristMenu.SecondColor = Color.green;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Green</color>");
            }
            bool flag6 = Mods.change11 == 5;
            if (flag6)
            {
                WristMenu.SecondColor = Color.magenta;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Magenta</color>");
            }
            bool flag7 = Mods.change11 == 6;
            if (flag7)
            {
                WristMenu.SecondColor = Color.cyan;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Cyan</color>");
            }
            bool flag8 = Mods.change11 == 7;
            if (flag8)
            {
                WristMenu.SecondColor = Color.yellow;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Yellow</color>");
            }
            bool flag9 = Mods.change11 == 8;
            if (flag9)
            {
                WristMenu.SecondColor = Color.blue;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Blue</color>");
            }
            bool flag10 = Mods.change11 == 9;
            if (flag10)
            {
                WristMenu.SecondColor = Color.grey;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Second Color: Grey</color>");
            }
            Mods.GetButton("Theme ChangerV2").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV3()
        {
            Mods.change12++;
            bool flag = Mods.change12 > 10;
            if (flag)
            {
                Mods.change12 = 1;
            }
            bool flag2 = Mods.change12 == 1;
            if (flag2)
            {
                WristMenu.ButtonColorDisable = Color.yellow;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Yellow</color>");
            }
            bool flag3 = Mods.change12 == 2;
            if (flag3)
            {
                WristMenu.ButtonColorDisable = Color.red;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Red</color>");
            }
            bool flag4 = Mods.change12 == 3;
            if (flag4)
            {
                WristMenu.ButtonColorDisable = Color.white;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: White</color>");
            }
            bool flag5 = Mods.change12 == 4;
            if (flag5)
            {
                WristMenu.ButtonColorDisable = Color.green;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Green</color>");
            }
            bool flag6 = Mods.change12 == 5;
            if (flag6)
            {
                WristMenu.ButtonColorDisable = Color.magenta;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Magenta</color>");
            }
            bool flag7 = Mods.change12 == 6;
            if (flag7)
            {
                WristMenu.ButtonColorDisable = Color.cyan;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Cyan</color>");
            }
            bool flag8 = Mods.change12 == 7;
            if (flag8)
            {
                WristMenu.ButtonColorDisable = Color.black;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Black</color>");
            }
            bool flag9 = Mods.change12 == 8;
            if (flag9)
            {
                WristMenu.ButtonColorDisable = Color.blue;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Blue</color>");
            }
            bool flag10 = Mods.change12 == 9;
            if (flag10)
            {
                WristMenu.ButtonColorDisable = Color.grey;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Grey</color>");
            }
            bool flag11 = Mods.change12 == 10;
            if (flag11)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disable Button Color: Clear</color>");
            }
            Mods.GetButton("Theme ChangerV3").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV4()
        {
            Mods.change13++;
            bool flag = Mods.change13 > 10;
            if (flag)
            {
                Mods.change13 = 1;
            }
            bool flag2 = Mods.change13 == 1;
            if (flag2)
            {
                WristMenu.ButtonColorEnabled = Color.magenta;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Magenta</color>");
            }
            bool flag3 = Mods.change13 == 2;
            if (flag3)
            {
                WristMenu.ButtonColorEnabled = Color.red;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Red</color>");
            }
            bool flag4 = Mods.change13 == 3;
            if (flag4)
            {
                WristMenu.ButtonColorEnabled = Color.white;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: White</color>");
            }
            bool flag5 = Mods.change13 == 4;
            if (flag5)
            {
                WristMenu.ButtonColorEnabled = Color.green;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Green</color>");
            }
            bool flag6 = Mods.change13 == 5;
            if (flag6)
            {
                WristMenu.ButtonColorEnabled = Color.yellow;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Yellow</color>");
            }
            bool flag7 = Mods.change13 == 6;
            if (flag7)
            {
                WristMenu.ButtonColorEnabled = Color.cyan;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Cyan</color>");
            }
            bool flag8 = Mods.change13 == 7;
            if (flag8)
            {
                WristMenu.ButtonColorEnabled = Color.black;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Black</color>");
            }
            bool flag9 = Mods.change13 == 8;
            if (flag9)
            {
                WristMenu.ButtonColorEnabled = Color.blue;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Blue</color>");
            }
            bool flag10 = Mods.change13 == 9;
            if (flag10)
            {
                WristMenu.ButtonColorEnabled = Color.grey;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Grey</color>");
            }
            bool flag11 = Mods.change13 == 10;
            if (flag11)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enable Button Color: Clear</color>");
            }
            Mods.GetButton("Theme ChangerV4").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV5()
        {
            Mods.change14++;
            bool flag = Mods.change14 > 9;
            if (flag)
            {
                Mods.change14 = 1;
            }
            bool flag2 = Mods.change14 == 1;
            if (flag2)
            {
                WristMenu.EnableTextColor = Color.black;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Black</color>");
            }
            bool flag3 = Mods.change14 == 2;
            if (flag3)
            {
                WristMenu.EnableTextColor = Color.red;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Red</color>");
            }
            bool flag4 = Mods.change14 == 3;
            if (flag4)
            {
                WristMenu.EnableTextColor = Color.white;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: White</color>");
            }
            bool flag5 = Mods.change14 == 4;
            if (flag5)
            {
                WristMenu.EnableTextColor = Color.green;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Green</color>");
            }
            bool flag6 = Mods.change14 == 5;
            if (flag6)
            {
                WristMenu.EnableTextColor = Color.yellow;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Yellow</color>");
            }
            bool flag7 = Mods.change14 == 6;
            if (flag7)
            {
                WristMenu.EnableTextColor = Color.cyan;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Cyan</color>");
            }
            bool flag8 = Mods.change14 == 7;
            if (flag8)
            {
                WristMenu.EnableTextColor = Color.magenta;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Magenta</color>");
            }
            bool flag9 = Mods.change14 == 8;
            if (flag9)
            {
                WristMenu.EnableTextColor = Color.blue;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Blue</color>");
            }
            bool flag10 = Mods.change14 == 9;
            if (flag10)
            {
                WristMenu.EnableTextColor = Color.grey;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Enabled Text Color: Grey</color>");
            }
            Mods.GetButton("Theme ChangerV5").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV6()
        {
            Mods.change15++;
            bool flag = Mods.change15 > 9;
            if (flag)
            {
                Mods.change15 = 1;
            }
            bool flag2 = Mods.change15 == 1;
            if (flag2)
            {
                WristMenu.DIsableTextColor = Color.black;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Black</color>");
            }
            bool flag3 = Mods.change15 == 2;
            if (flag3)
            {
                WristMenu.DIsableTextColor = Color.red;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Red</color>");
            }
            bool flag4 = Mods.change15 == 3;
            if (flag4)
            {
                WristMenu.DIsableTextColor = Color.white;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: White</color>");
            }
            bool flag5 = Mods.change15 == 4;
            if (flag5)
            {
                WristMenu.DIsableTextColor = Color.green;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Green</color>");
            }
            bool flag6 = Mods.change15 == 5;
            if (flag6)
            {
                WristMenu.DIsableTextColor = Color.yellow;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Yellow</color>");
            }
            bool flag7 = Mods.change15 == 6;
            if (flag7)
            {
                WristMenu.DIsableTextColor = Color.cyan;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Cyan</color>");
            }
            bool flag8 = Mods.change15 == 7;
            if (flag8)
            {
                WristMenu.DIsableTextColor = Color.magenta;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Magenta</color>");
            }
            bool flag9 = Mods.change15 == 8;
            if (flag9)
            {
                WristMenu.DIsableTextColor = Color.blue;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Blue</color>");
            }
            bool flag10 = Mods.change15 == 9;
            if (flag10)
            {
                WristMenu.DIsableTextColor = Color.grey;
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Disabled Text Color: Grey</color>");
            }
            Mods.GetButton("Theme ChangerV6").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ThemeChangerV7()
        {
            Mods.change16++;
            if (Mods.change16 > 6)
            {
                Mods.change16 = 1;
            }
            if (Mods.change16 == 1)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Button Sound: Normal</color>");
            }
            if (Mods.change16 == 2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Button Sound: Stump</color>");
            }
            if (Mods.change16 == 3)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Button Sound: AK47</color>");
            }
            if (Mods.change16 == 4)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Button Sound: Glass</color>");
            }
            if (Mods.change16 == 5)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Button Sound: KeyBoard</color>");
            }
            if (Mods.change16 == 6)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>THEME CHANGER</color><color=white>] Button Sound: Cayon Pillow</color>"); // this sounds the best tbh
            }
            Mods.GetButton("Theme ChangerV7").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }
        public static void ChangeGunType()
        {
            Mods.change17++;
            if (Mods.change17 > 2)
            {
                Mods.change17 = 1;
            }
            if (Mods.change17 == 1)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN TYPE</color><color=white>] Current Type: Ball</color>");
            }
            if (Mods.change17 == 2)
            {
                NotifiLib.SendNotification("<color=white>[</color><color=blue>GUN TYPE</color><color=white>] Current Type: Line</color>");
            }
            Mods.GetButton("Change Gun Type").enabled = new bool?(false);
            WristMenu.DestroyMenu();
            WristMenu.instance.Draw();
        }

        public static bool inSettings = false;
        public static bool inCat1 = false;
        public static bool inCat2 = false;
        public static bool inCat3 = false;
        public static bool inCat4 = false;
        public static bool inCat5 = false;
        public static bool inCat6 = false;
        public static bool inCat7 = false;
        public static bool inCat8 = false;
        public static bool inFav = false;
        public static string room = "";
        public static GameObject orb;
        public static GameObject orb2;
        public static bool head3;
        public static bool fps;
        public static bool invisplat = false;
        public static bool invisMonke = false;
        public static bool stickyplatforms = false;
        private static Vector3 scale = new Vector3(0.0125f, 0.28f, 0.3825f);
        public static int change1 = 1;
        public static int change2 = 1;
        public static int change3 = 1;
        public static int change4 = 1;
        public static int change5 = 1;
        public static int change6 = 1;
        public static int change7 = 1;
        public static int change8 = 1;
        public static int change9 = 1;
        public static int change10 = 1;
        public static int change11 = 1;
        public static int change12 = 1;
        public static int change13 = 1;
        public static int change14 = 1;
        public static int change15 = 1;
        public static int change16 = 1;
        public static int change17 = 1;
        public static bool longArms;
        public static bool GhostMonkGUI;
        public static bool InvisMonkGUI;
        public static bool ghostMonke = false;
        public static bool longerarms;
        public static bool longlongarms;
        public static bool rightHand = false;
        public static bool Head1;
        public static bool head2;
        public static bool lastHit2;
        public static bool lastHit;
        public static bool right;
        public static float balll435342111;
        public static bool headback;
        public static bool downhead;
        public static GameObject pointer;
        public static LineRenderer Line;
        private static bool once_left;
        private static bool once_right;
        public static bool FavBool;
        public static bool FPSPage;
        public static bool RGBMenu;
        public static Vector3 previousMousePosition;
        private static bool once_left_false;
        public static float FCMovmentSpeed = 6f;
        private static bool once_right_false;
        private static GameObject[] jump_left_network = new GameObject[9999];
        private static GameObject[] jump_right_network = new GameObject[9999];
        private static GameObject jump_left_local = null;
        private static GameObject jump_right_local = null;
        private static GradientColorKey[] colorKeysPlatformMonke = new GradientColorKey[4];
    }
    internal class random
    {
        internal static int Next(int length)
        {
            throw new NotImplementedException();
        }
    }
}

