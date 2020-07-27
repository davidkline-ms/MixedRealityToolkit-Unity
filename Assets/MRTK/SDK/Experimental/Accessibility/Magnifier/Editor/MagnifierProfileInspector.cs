// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.﻿

using Microsoft.MixedReality.Toolkit.Editor;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Utilities.Editor;
using UnityEditor;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility.Editor
{
    [CustomEditor(typeof(MixedRealityMagnifierProfile))]
    public class MagnifierProfileInspector : BaseMixedRealityToolkitConfigurationProfileInspector
    {
        private const string ProfileTitle = "Magnifier Settings";
        private const string ProfileDescription = ""; // todo - description

        private SerializedProperty magnificationFactor;
        private SerializedProperty minDistance;

        protected override void OnEnable()
        {
            base.OnEnable();

            magnificationFactor = serializedObject.FindProperty("magnificationFactor");
            minDistance = serializedObject.FindProperty("minDistance");
        }

        public override void OnInspectorGUI()
        {
            if (!RenderProfileHeader(ProfileTitle, ProfileDescription, target))
            {
                return;
            }

            using (new EditorGUI.DisabledGroupScope(IsProfileLock((BaseMixedRealityProfile)target)))
            {
                serializedObject.Update();

                EditorGUILayout.Space();

                EditorGUILayout.PropertyField(magnificationFactor);
                EditorGUILayout.PropertyField(minDistance);
            }
        }

        protected override bool IsProfileInActiveInstance()
        {
            return true;
            //var profile = target as BaseMixedRealityProfile;
            //return MixedRealityToolkit.IsInitialized && profile != null &&
            //       profile == MixedRealityToolkit.Instance.ActiveProfile.BoundaryVisualizationProfile;
        }
    }
}
