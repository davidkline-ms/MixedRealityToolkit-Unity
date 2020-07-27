// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using Microsoft.MixedReality.Toolkit.Utilities;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Experimental.Accessibility
{
    /// <summary>
    /// 
    /// </summary>
    public class MixedRealityMagnifier : BaseCoreSystem, IMixedRealityMagnifier
    {
        public MixedRealityMagnifier(
            MixedRealityMagnifierProfile profile = null) : base(profile)
        { }

        /// <summary>
        /// Reads the contents of the MixedRealityMagnifierProfile.
        /// </summary>
        private void ReadProfile()
        {
            if (MagnifierProfile == null)
            {
                Debug.LogError($"{Name} requires a configuration profile to run properly.");
                return;
            }

            MagnificationFactor = MagnifierProfile.MagnificationFactor;
            MinimumDistance = MagnifierProfile.MinimumDistance;
        }

        #region IMixedRealityMagnifier

        private float magnificationFactor;

        private AutoStartBehavior startupBehavior = AutoStartBehavior.ManualStart;

        /// <inheritdoc />
        public AutoStartBehavior StartupBehavior
        {
            get => startupBehavior;
            set => startupBehavior = value;
        }

        /// <inheritdoc />
        public float MagnificationFactor
        {
            get => magnificationFactor;

            set
            {
                if (magnificationFactor != value)
                {
                    // todo: apply upper bound
                    if (value < 1.0f)
                    {
                        Debug.LogError($"Invalid MagnificationFactor. Valid values must be greater than or equal to 1.0");
                        return;
                    }

                    magnificationFactor = value;
                }
            }
        }

        private float minDistance = 0.3f;

        /// <summary>
        /// 
        /// </summary>
        public float MinimumDistance
        {
            get => minDistance;
            // todo apply range
            set => minDistance = value;
        }

        private bool isRunning = false;

        /// <summary>
        /// 
        /// </summary>
        public bool IsRunning
        {
            get => isRunning;
            private set => isRunning = value;
        }


        /// <inheritdoc />
        public void Suspend()
        {
            IsRunning = false;
            suspendedByDisable = false;

            // Return the target hologram to the original scale.
            // todo
        }

        /// <inheritdoc />
        public void Resume()
        {
            IsRunning = true;
        }

        #endregion // IMixedRealityMagnifier

        #region IMixedRealityService

        /// <inheritdoc/>
        public override string Name { get; protected set; } = "Mixed Reality Magnifier";

        /// <inheritdoc/>
        public MixedRealityMagnifierProfile MagnifierProfile => ConfigurationProfile as MixedRealityMagnifierProfile;

        /// <inheritdoc />
        public override void Initialize()
        {
            base.Initialize();
            ReadProfile();
            if (StartupBehavior == AutoStartBehavior.AutoStart)
            {
                Resume();
            }
        }

        /// <inheritdoc />
        public override void Reset()
        {
            base.Reset();
            Disable();
            Initialize();
            Enable();
        }

        /// <inheritdoc />
        public override void Enable()
        {
            base.Enable();
            if (!IsRunning &&
                (StartupBehavior == AutoStartBehavior.AutoStart)
                && suspendedByDisable)
            {
                // Resume after we were disabled.
                Resume();
            }
        }

        /// <inheritdoc />
        public override void Update()
        {
            base.Update();
            
            if (IsRunning)
            {
                GameObject focusedObject = CoreServices.InputSystem?.GazeProvider?.GazeTarget;
                if (focusedObject == null)
                {
                    return;
                }

                // todo
            }
        }

        private bool suspendedByDisable = false;

        /// <inheritdoc />
        public override void Disable()
        {
            if (IsRunning)
            {
                Suspend();
                suspendedByDisable = true;
            }
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
