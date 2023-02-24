using UnityEditor;

namespace Builder.Bundle
{
    public class iOSBundleSetting : IBundleSetting
    {
        #region implement IBundleSetting
        void IBundleSetting.SetBundleId(string appId)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, appId);
        }
        void IBundleSetting.SetBundleVersion(string version, int versionCode)
        {
            PlayerSettings.iOS.buildNumber = versionCode.ToString();
        }
        void IBundleSetting.SetKeystore(string pass, string keyName, string keyPass)
        {
            // hook
        }
        #endregion
    }
}
