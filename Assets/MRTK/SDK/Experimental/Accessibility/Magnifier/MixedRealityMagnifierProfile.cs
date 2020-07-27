// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility
{
    /// <summary>
    /// Configuration profile for <see cref="MixedRealityMagnifier"/> service.
    /// </summary>
	[MixedRealityServiceProfile(typeof(IMixedRealityMagnifier))]
    [CreateAssetMenu(fileName = "DefaultMixedRealityMagnifierProfile", menuName = "Mixed Reality Toolkit/Magnifier Configuration Profile")]
    public class MixedRealityMagnifierProfile : BaseMixedRealityProfile
    {
        [SerializeField]
        [Tooltip("The magnification factor to apply to holograms. Ex: 1.5 magnifies by 50%.")]
        private float magnificationFactor = 1.5f;

        /// <summary>
        /// The magnification factor to apply to holograms.
        /// </summary>
        /// <remarks>
        /// A value of 1.5 zooms the hologram by 50 percent.
        /// </remarks>
        public float MagnificationFactor => magnificationFactor;

        //[PhysicsLayer]
        [SerializeField]
        [Tooltip("The physics layer to use for suppressing hologram magnification.")]
        private int suppressMagnificationPhysicsLayer = 30;

        /// <summary>
        /// The physics layer to use for suppressing hologramn magnification.
        /// </summary>
        /// <remarks>
        /// Holograms placed on this layer will not be magnified.
        /// </remarks>
        public int SuppressMagnificationPhysicsLayer => suppressMagnificationPhysicsLayer;
    }
}
