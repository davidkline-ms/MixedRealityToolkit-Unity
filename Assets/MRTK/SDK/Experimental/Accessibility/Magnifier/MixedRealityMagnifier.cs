// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility
{
    /// <summary>
    /// 
    /// </summary>
    public class MixedRealityMagnifier : BaseCoreSystem, IMixedRealityMagnifier
    {
        public MixedRealityMagnifier(
            // todo: define profile
            BaseMixedRealityProfile profile = null) : base(profile)
        { }

        /// <summary>
        /// Reads the contents of the MixedRealityMagnifierProfile.
        /// </summary>
        private void ReadProfile()
        {
            // todo
        }

        #region IMixedRealityMagnifier

        private float magnificationFactor;

        /// <inheritdoc />
        public float MagnificationFactor
        {
            get => magnificationFactor;

            set
            {
                if (magnificationFactor != value)
                {
                    if (value < 1.0f)
                    {
                        Debug.LogError($"Invalid MagnificationFactor. Valid values must be greater than or equal to 1.0");
                        return;
                    }

                    magnificationFactor = value;
                }
            }
        }

        /// <inheritdoc />
        public void Suspend()
        {
            // todo
        }

        /// <inheritdoc />
        public void Resume()
        {
            // todo
        }

        #endregion // IMixedRealityMagnifier

        #region IMixedRealityService

        /// <inheritdoc/>
        public override string Name { get; protected set; } = "Mixed Reality Magnifier";

        /// <inheritdoc />
        public override BaseMixedRealityProfile ConfigurationProfile => null; // todo: create a profile with the magnification factor and other settings

        /// <inheritdoc />
        public override void Initialize()
        {
            ReadProfile();
            // todo
            base.Initialize();
        }

        /// <inheritdoc />
        public override void Reset()
        {
            //todo
            base.Reset();
        }

        /// <inheritdoc />
        public override void Enable()
        {
            base.Enable();
            // todo
        }

        /// <inheritdoc />
        public override void Update()
        {
            base.Update();
            // todo
        }

        /// <inheritdoc />
        public override void LateUpdate()
        {
            base.LateUpdate();
            // todo
        }

        /// <inheritdoc />
        public override void Disable()
        {
            // todo
            base.Disable();
        }

        /// <inheritdoc />
        public override void Destroy()
        {
            // todo
            base.Destroy();
        }

        #endregion // IMixedRealityService
    }
}
