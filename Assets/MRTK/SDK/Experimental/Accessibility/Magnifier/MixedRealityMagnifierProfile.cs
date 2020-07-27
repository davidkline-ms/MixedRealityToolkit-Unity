// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility
{
    /// <summary>
    /// Configuration profile for <see cref="MixedRealityMagnifier"/> service.
    /// </summary>
	[MixedRealityServiceProfile(typeof(IMixedRealityMagnifier))]
    [CreateAssetMenu(fileName = "DefaultMixedRealityMagnifierProfile", menuName = "Mixed Reality Toolkit/Profiles/Magnifier Configuration Profile")]
    public class MixedRealityMagnifierProfile : BaseMixedRealityProfile
    {
        [SerializeField]
        [Tooltip("The magnification factor to apply to holograms. Ex: 1.5 magnifies by 50%.")]
        [Range(1.0f, 5.0f)]
        private float magnificationFactor = 1.5f;

        /// <summary>
        /// The magnification factor to apply to holograms.
        /// </summary>
        public float MagnificationFactor => magnificationFactor;

        [SerializeField]
        [Tooltip("Holograms must be at least this distance, in meters, from the user in order to be magnified.")]
        [Range(0.0f, 10.0f)]
        public float minDistance = 0.3f;

        /// <summary>
        /// Holograms must be at least this distance, in meters, from the user in order to be magnified.
        /// </summary>
        public float MinimumDistance => minDistance;
    }
}
