using MelonLoader;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using EPOOutline;
using UnityEngine.InputSystem;


namespace OptiBot
{
    public static class BuildInfo
    {
        public const string Name = "OptiBot"; // Name of the Mod.  (MUST BE SET)
        public const string Description = "Mod for Testing"; // Description for the Mod.  (Set as null if none)
        public const string Author = "TestAuthor"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class OptiBot : MelonMod
    {
        
        public override void OnSceneWasInitialized(int buildindex, string sceneName) // Runs when a Scene has Initialized and is passed the Scene's Build Index and Name.
        {
            GameObject mainCamera = GameObject.Find("Main Camera");
            Screen.SetResolution(1280, 720, true, 60);
            mainCamera.GetComponent<PostProcessLayer>().enabled = false;
            mainCamera.GetComponents<Outliner>()[0].enabled = false;
            mainCamera.GetComponents<Outliner>()[2].enabled = false;
            //MelonLogger.Msg("OnSceneWasInitialized: " + buildindex.ToString() + " | " + sceneName);
        }

    }
}