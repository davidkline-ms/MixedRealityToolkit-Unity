// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility
{
    /// <summary>
    /// Interface that defines the Mixed Reality Toolkit hologram magnifier feature.
    /// </summary>
    public interface IMixedRealityMagnifier : IMixedRealityService // todo: EventSystem?
    {
        /// <summary>
        /// Factor by which holograms will be magnified.
        /// </summary>
        /// <remarks>
        /// A factor of 1.0 corresponds to no magnification, and larger values result in a
        /// corresponding amount of magnification. For example, a value of 1.5 makes hologram
        /// 50 percent larger. A magnification factor less than 1.0 is not valid and will not be accepted.
        /// </remarks>
        // todo: what is a valid max? 5.0? 10.0?
        float MagnificationFactor { get; set; }

        /// <summary>
        /// Collection of objects that be and remain magnified.
        /// </summary>
        List<GameObject> PersistentMagnification { get; }

        /// <summary>
        /// Collection of objects that should never be magnified.
        /// </summary>
        List<GameObject> SuppressedMagnification { get; }

        /// <summary>
        /// Suspends magnification behavior.
        /// </summary>
        /// <remarks>
        /// Persistent magnification objects will return to their nomninal size.
        /// </remarks>
        void Suspend();

        /// <summary>
        /// Resumes magnification behavior.
        /// </summary>
        /// <remarks>
        /// Persistent magnification objects will be magnified.
        /// </remarks>
        void Resume();
    }
}
