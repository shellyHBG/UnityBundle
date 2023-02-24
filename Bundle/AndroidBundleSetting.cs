using UnityEditor;

namespace Builder.Bundle
{
    public class AndroidBundleSetting : IBundleSetting
    {
        #region implement IBundleSetting
        void IBundleSetting.SetBundleId(string appId)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, appId);
        }
        void IBundleSetting.SetBundleVersion(string version, int versionCode)
        {
            PlayerSettings.bundleVersion = version;
            PlayerSettings.Android.bundleVersionCode = versionCode;
        }
        void IBundleSetting.SetKeystore(string pass, string keyName, string keyPass)
        {
            PlayerSettings.keystorePass = pass;
            PlayerSettings.Android.keyaliasName = keyName;
            PlayerSettings.Android.keyaliasPass = keyPass;
        }
        #endregion
    }
}
