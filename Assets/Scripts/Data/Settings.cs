﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VRtist
{

    [CreateAssetMenu(menuName = "VRtist/Settings")]
    public class Settings : ScriptableObject
    {
        public bool displayGizmos = true;
        public bool displayWorldGrid = true;
        public bool displayFPS = false;
        public float masterVolume = 0f;
        public float ambientVolume = -35f;
        public float uiVolume = 0f;
        public bool rightHanded = true;
        public bool forcePaletteOpen = false;

        public Vector3 palettePosition;
        public Quaternion paletteRotation;
        public bool pinnedPalette = false;

        public Vector3 dopeSheetPosition;
        public Quaternion dopeSheetRotation;
        public bool dopeSheetVisible = false;

        public Vector3 cameraPreviewPosition;
        public Quaternion cameraPreviewRotation;
        public bool cameraPreviewVisible = false;

        public Vector3 cameraFeedbackPosition;
        public Quaternion cameraFeedbackRotation;
        public bool cameraFeedbackVisible = false;
        public float cameraDamping = 50f;

        public bool castShadows = false;

        [Range(1.0f, 100.0f)]
        public float scaleSpeed = 50f;
    
        public void Reset()
        {
            displayGizmos = true;
            displayWorldGrid = true;
            displayFPS = false;
            masterVolume = 0f;
            ambientVolume = -35f;
            uiVolume = 0f;
            rightHanded = true;
            forcePaletteOpen = false;
            pinnedPalette = false;
            dopeSheetVisible = false;
            cameraPreviewVisible = false;
            cameraFeedbackVisible = false;
            cameraDamping = 50f;
            castShadows = false;
            scaleSpeed = 50f;
        }

        public void SetWindowPosition(Transform window)
        {
            if (window.name == "PaletteHandle")
            {
                palettePosition = window.localPosition;
                paletteRotation = window.localRotation;
            }
            if (window.name == "DopesheetHandle")
            {
                dopeSheetPosition = window.localPosition;
                dopeSheetRotation = window.localRotation;
            }
            if (window.name == "CameraPreviewHandle")
            {
                cameraPreviewPosition = window.localPosition;
                cameraPreviewRotation = window.localRotation;
            }
            if (window.name == "CameraFeedback")
            {
                cameraFeedbackPosition = window.localPosition;
                cameraFeedbackRotation = window.localRotation;
            }
        }
    }

}