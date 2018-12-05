// InstallOptions_FluvioFree.cs
// Copyright (c) 2011-2017 Thinksquirrel Inc.

using ASInstaller = ASInstaller_FluvioFree;
using ASInstallerWindow = ASInstallerWindow_FluvioFree;
using UnityEditor;
using UnityEngine;

#if !ASINSTALLER_DEVELOPMENT
[InitializeOnLoad]
#endif

public static class InstallOptions_FluvioFree
{
    #region Static and Constant Fields
    static bool installForJavaScript;
    #endregion

    #region Constructors
    static InstallOptions_FluvioFree()
    {
        ASInstaller.OnInstallGUI += OnInstallGUI;
        ASInstaller.OnPostInstall += OnPostInstall;
    }
    #endregion

    static bool OnInstallGUI()
    {
        var i = !GUILayout.Toggle(!installForJavaScript, "Install for C#", EditorStyles.radioButton);

        if (i == false && i != installForJavaScript)
            installForJavaScript = false;

        var j = GUILayout.Toggle(installForJavaScript, "Install for JavaScript", EditorStyles.radioButton);

        if (j && j != installForJavaScript)
            installForJavaScript = true;

        return true;
    }
    static bool OnPostInstall(string packageName)
    {
        EditorPrefs.SetBool("Thinksquirrel.FluvioEditor.InstallForJavaScript", installForJavaScript);
        if (installForJavaScript) EditorPrefs.SetString("ASInstaller.LastInstall.Options", "InstallForJavaScript");
        return true;
    }
}
