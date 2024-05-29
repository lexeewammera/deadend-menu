using Photon.Realtime;
using HarmonyLib;
using GTAG_NotificationLib;
using Photon.Pun;

namespace MalachiTemp.Backend
{
    /*
       COPYRIGHT NOTE: THIS TEMPLATE IS COPYRIGHTED MATERIAL FROM "Project Malachi" AND AT ALL TIMES 
       MUST BE CREDITTED. IF ANY MATERIAL FROM "MalachiTemp" FOUND IN ANY OTHER PROJECT/THING WITHOUT 
       CREDIT OR PERMISSION MUST AND WILL BE REMOVED IMMEDIATELY
    */

    [HarmonyPatch(typeof(GorillaNot))]
    [HarmonyPatch("OnPlayerEnteredRoom", MethodType.Normal)]
    internal class OnJoin : HarmonyPatch
    {
        private static void Prefix(Player newPlayer)
        {
            NotifiLib.SendNotification("<color=blue>[ROOM]:</color> Player " + newPlayer.NickName + " Joined Lobby");
        }
    }

    [HarmonyPatch(typeof(GorillaNot))]
    [HarmonyPatch("OnPlayerLeftRoom", MethodType.Normal)]
    internal class OnLeave : HarmonyPatch
    {
        private static void Prefix(Player otherPlayer)
        {
            if (otherPlayer != PhotonNetwork.LocalPlayer)
            {
                NotifiLib.SendNotification("<color=blue>[ROOM]:</color> Player " + otherPlayer.NickName + " Left Lobby");
                if (PhotonNetwork.IsMasterClient)
                {
                    NotifiLib.SendNotification("<color=yellow>[ROOM]: YOU ARE NOW MASTER!</color>");
                }
            }
        }
    }
}