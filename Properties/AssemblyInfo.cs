using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(OptiBot.BuildInfo.Description)]
[assembly: AssemblyDescription(OptiBot.BuildInfo.Description)]
[assembly: AssemblyCompany(OptiBot.BuildInfo.Company)]
[assembly: AssemblyProduct(OptiBot.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + OptiBot.BuildInfo.Author)]
[assembly: AssemblyTrademark(OptiBot.BuildInfo.Company)]
[assembly: AssemblyVersion(OptiBot.BuildInfo.Version)]
[assembly: AssemblyFileVersion(OptiBot.BuildInfo.Version)]
[assembly: MelonInfo(typeof(OptiBot.OptiBot), OptiBot.BuildInfo.Name, OptiBot.BuildInfo.Version, OptiBot.BuildInfo.Author, OptiBot.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]