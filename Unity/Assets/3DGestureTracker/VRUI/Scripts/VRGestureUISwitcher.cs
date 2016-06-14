﻿using UnityEngine;
using System.Collections;

namespace WinterMute
{

    public class VRGestureUISwitcher : MonoBehaviour
    {
        VRGestureRig rig;
        IInput input;

        Transform playerHead;
        Transform playerHandL;
        Transform playerHandR;

        public VRGestureUI vrGestureUI;

        void Start()
        {
            rig = VRGestureManager.Instance.rig;

            playerHead = rig.headTF;
            playerHandR = rig.rHandTF;
            playerHandL = rig.lHandTF;

            input = rig.GetInput(Config.gestureHand);
        }

        void Update ()
        {
            // if vr button 1 toggle the vr gesture UI visibility
            if (input.GetButtonDown(InputOptions.Button.Button1))
            {
                vrGestureUI.gameObject.SetActive(!vrGestureUI.gameObject.activeInHierarchy);
            }
        }
    }
}