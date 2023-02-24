using Builder.Bundle;
using UnityEditor;

public class TestBundleSetting
{
    [MenuItem("Unit/Builder/BundleSetting/Setup")]
    public static void Setup()
    {
        IBundleSetting bundle = BundleSettingFactory.CreateBundle();
        bundle.SetBundleId("x.y.z");
        bundle.SetBundleVersion("1.0.1", 1);
        bundle.SetKeystore("1234", "key1234", "pass1234");
    }
}
