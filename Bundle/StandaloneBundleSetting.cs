using UnityEditor;

namespace Builder.Bundle
{
    public class StandaloneBundleSetting : IBundleSetting
    {
        #region implement IBundleSetting
        void IBundleSetting.SetBundleId(string appId)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Standalone, appId);
        }
        void IBundleSetting.SetBundleVersion(string version, int versionCode)
        {
            PlayerSettings.bundleVersion = version;
            PlayerSettings.macOS.buildNumber = versionCode.ToString();
        }
        void IBundleSetting.SetKeystore(string pass, string keyName, string keyPass)
        {
            // hook
        }
        #endregion
    }
}
