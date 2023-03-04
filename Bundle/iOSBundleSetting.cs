using UnityEditor;

namespace Builder.Bundle
{
    public class iOSBundleSetting : IBundleSetting
    {
        #region implement IBundleSetting
        void IBundleSetting.SetBundleId(string inAppId)
        {
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, inAppId);
        }
        void IBundleSetting.SetBundleVersion(string inVersion, int inVersionCode)
        {
            PlayerSettings.iOS.buildNumber = inVersionCode.ToString();
        }
        void IBundleSetting.SetKeystore(string inPass, string inKeyName, string inKeyPass)
        {
            // hook
        }
        #endregion
    }
}
