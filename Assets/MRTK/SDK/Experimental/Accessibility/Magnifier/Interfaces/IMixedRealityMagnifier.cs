// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility
{
    /// <summary>
    /// Interface that defines the Mixed Reality Toolkit hologram magnifier feature.
    /// </summary>
    public interface IMixedRealityMagnifier : IMixedRealityEventSystem
    {
        /// <summary>
        /// Factor by which holograms will be magnified.
        /// </summary>
        /// <remarks>
        /// A factor of 1.0 corresponds to no magnification, and larger values result in a
        /// corresponding amount of magnification. For example, a value of 1.5 makes hologram
        /// 50 percent larger. A magnification factor less than 1.0 is not valid and will not be accepted.
        /// </remarks>
        float MagnificationFactor { get; set; }

        // todo: how to suppress magnification for specific objects?

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
