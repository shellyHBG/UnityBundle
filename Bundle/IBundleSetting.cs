using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Builder.Bundle
{
    public interface IBundleSetting
    {
        void SetBundleId(string appId);
        void SetBundleVersion(string version, int versionCode);
        void SetKeystore(string pass, string keyName, string keyPass);
    }
}
