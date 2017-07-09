using Microsoft.Extensions.Logging;

namespace Net.Chdk.Meta.Providers.Camera.Chdk
{
    sealed class ChdkCameraValidator : CameraValidator
    {
        public ChdkCameraValidator(ILogger<ChdkCameraValidator> logger)
            : base(logger)
        {
        }
    }
}
