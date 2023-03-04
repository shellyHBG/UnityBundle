using UnityEditor;

namespace Builder.Bundle
{
    public class StandaloneBundleSetting : IBundleSetting
    {
        #region implement IBundleSetting
        void IBundleSetting.SetBundleId(string inAppId)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Standalone, inAppId);
        }
        void IBundleSetting.SetBundleVersion(string inVersion, int inVersionCode)
        {
            PlayerSettings.bundleVersion = inVersion;
            PlayerSettings.macOS.buildNumber = inVersionCode.ToString();
        }
        void IBundleSetting.SetKeystore(string inPass, string inKeyName, string inKeyPass)
        {
            // hook
        }
        #endregion
    }
}
