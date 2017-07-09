using System.Collections.Generic;

namespace Net.Chdk.Meta.Providers.Camera.Chdk
{
    sealed class ChdkCameraPlatformProvider : CameraPlatformProvider
    {
        protected override T TryGetValue<T>(IDictionary<string, T> values, string platform)
        {
            T value;
            values.TryGetValue(platform, out value);
            return value;
        }
    }
}
