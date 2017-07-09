using Microsoft.Extensions.Logging;

namespace Net.Chdk.Meta.Providers.Camera.Chdk
{
    sealed class ChdkCameraModelValidator : CameraModelValidator
    {
        public ChdkCameraModelValidator(ILogger<ChdkCameraModelValidator> logger)
            : base(logger)
        {
        }
    }
}
