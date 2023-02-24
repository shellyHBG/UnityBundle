namespace Builder.Bundle
{
    public class BundleSettingFactory
    {
        public static IBundleSetting CreateBundle()
        {
            IBundleSetting bundle = null;
#if UNITY_ANDROID
            bundle = new AndroidBundleSetting();
#elif UNITY_IOS
            bundle = new iOSBundleSetting();
#else
            bundle = new StandaloneBundleSetting();
#endif
            return bundle;
        }
    }
}
