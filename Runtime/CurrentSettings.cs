using UnityEngine;

namespace com.unity.test.performance.runtimesettings
{
    public class CurrentSettings : ScriptableObject
    {
        public string ProjectName;
        public string PlayerGraphicsApi;
        public bool MtRendering;
        public bool GraphicsJobs;
        public bool EnableBurst;
        public string ColorSpace;
        public string Username;
        public string RenderPipeline;
        public int AntiAliasing;
        public string TestsRevision;
        public string TestsRevisionDate;
        public string TestsBranch;
        public string PackageUnderTestName;
        public string PackageUnderTestVersion;
        public string PackageUnderTestRevision;
        public string PackageUnderTestRevisionDate;
        public string PackageUnderTestBranch;
        public string ScriptingBackend;
        public string JobLink;
        public int JobWorkerCount;
        public string ApiCompatibilityLevel;
        public bool StripEngineCode;
        public string ManagedStrippingLevel;
        public bool ScriptDebugging;
        public string TestProjectName;
        public string TestProjectRevision;
        public string TestProjectRevisionDate;
        public string TestProjectBranch;
        public string EnabledXrTarget;
        public string StereoRenderingMode;
        public string StereoRenderingModeDesktop;
        public string StereoRenderingModeAndroid;
        public string SimulationMode;
        public string PluginVersion;
        public string DeviceRuntimeVersion;
        public string FfrLevel;
        public string AndroidTargetArchitecture;
    }
}
