#if !UNITY_4_6 && !UNITY_4_7
#define UNITY_5_0_PLUS
#endif

#if !FLUVIO_DEVELOPMENT && !ASINSTALLER_DEVELOPMENT
using UnityEditor;

#if UNITY_5_0_PLUS
// ReSharper disable once CheckNamespace
namespace Thinksquirrel.FluvioEditor.Inspectors
{
#endif
    // This is just a dummy class to stop shader warnings when Fluvio isn't installed
    internal class FluidEffectShaderInspector
#if UNITY_5_0_PLUS
        : ShaderGUI
#else
        : MaterialEditor
#endif
    {}
#if UNITY_5_0_PLUS
}
#endif
#endif