using UnityEditor;

namespace Builder.Bundle
{
    public class AndroidBundleSetting : IBundleSetting
    {
        #region implement IBundleSetting
        void IBundleSetting.SetBundleId(string inAppId)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, inAppId);
        }
        void IBundleSetting.SetBundleVersion(string inVersion, int inVersionCode)
        {
            PlayerSettings.bundleVersion = inVersion;
            PlayerSettings.Android.bundleVersionCode = inVersionCode;
        }
        void IBundleSetting.SetKeystore(string inPass, string inKeyName, string inKeyPass)
        {
            PlayerSettings.keystorePass = inPass;
            PlayerSettings.Android.keyaliasName = inKeyName;
            PlayerSettings.Android.keyaliasPass = inKeyPass;
        }
        #endregion
    }
}
