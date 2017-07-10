using System.Collections.Generic;

namespace Net.Chdk.Meta.Providers.Camera.Chdk
{
    sealed class ChdkCameraPlatformProvider : CameraPlatformProvider
    {
        protected override T TryGetValue<T>(IDictionary<string, T> values, string platform)
        {
            values.TryGetValue(platform, out T value);
            return value;
        }
    }
}
