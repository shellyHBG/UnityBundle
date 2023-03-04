namespace Builder.Bundle
{
    public interface IBundleSetting
    {
        void SetBundleId(string inAppId);
        void SetBundleVersion(string inVersion, int inVersionCode);
        void SetKeystore(string inPass, string inKeyName, string inKeyPass);
    }
}
