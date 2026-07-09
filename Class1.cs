using System;
using HarmonyLib;
using UnityEngine;
using BepInEx;
using Photon.Pun;

namespace _2D_Monks
{
    [BepInPlugin("2DMonks", "2DMonks", "0.0.1")]
    public class Class1 : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("2DMonks");
            harmony.PatchAll();
            Debug.Log("\n███╗   ███╗ █████╗ ██████╗ ███████╗    ██████╗ ██╗   ██╗\r\n████╗ ████║██╔══██╗██╔══██╗██╔════╝    ██╔══██╗╚██╗ ██╔╝\r\n██╔████╔██║███████║██║  ██║█████╗      ██████╔╝ ╚████╔╝ \r\n██║╚██╔╝██║██╔══██║██║  ██║██╔══╝      ██╔══██╗  ╚██╔╝  \r\n██║ ╚═╝ ██║██║  ██║██████╔╝███████╗    ██████╔╝   ██║   \r\n╚═╝     ╚═╝╚═╝  ╚═╝╚═════╝ ╚══════╝    ╚═════╝    ╚═╝   \r\n\r\n ██████╗██╗   ██╗██████╗ ███████╗\r\n██╔════╝██║   ██║██╔══██╗██╔════╝\r\n██║     ██║   ██║██████╔╝█████╗  \r\n██║     ██║   ██║██╔══██╗██╔══╝  \r\n╚██████╗╚██████╔╝██████╔╝███████╗\r\n ╚═════╝ ╚═════╝ ╚═════╝ ╚══════╝");
        }

        void Update()
        {
            if (PhotonNetwork.InRoom)
            {
                foreach (VRRig Player in VRRigCache.ActiveRigs)
                {
                    if (Player != GorillaTagger.Instance.offlineVRRig)
                    {
                        Player.transform.localScale = new Vector3(1f, 1f, 0f);
                    }
                }
            }
        }
    }

}
