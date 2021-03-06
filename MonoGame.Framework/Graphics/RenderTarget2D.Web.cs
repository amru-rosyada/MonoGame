// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;

namespace Microsoft.Xna.Framework.Graphics
{
    public partial class RenderTarget2D
    {
        private void PlatformConstruct(
            GraphicsDevice graphicsDevice, 
            int width, 
            int height, 
            bool mipMap,
            SurfaceFormat preferredFormat, 
            DepthFormat preferredDepthFormat,
            int preferredMultiSampleCount,
            RenderTargetUsage usage, 
            bool shared)
        {
            throw new NotImplementedException();
        }

        private void PlatformGraphicsDeviceResetting()
        {
            throw new NotImplementedException();
        }

        private void PlatformDispose(bool disposing)
        {
            throw new NotImplementedException();
        }
    }
}
