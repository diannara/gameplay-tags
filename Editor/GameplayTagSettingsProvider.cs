using System.Collections.Generic;
using System.Text.RegularExpressions;

using UnityEditor;

using UnityEngine;
using UnityEngine.UIElements;

namespace Diannara.GameplayTags.Editor
{
    public static class GameplayTagSettingsProvider
    {
        private static readonly Regex TagPattern = new Regex(@"^[A-Za-z]+(\.[A-Za-z]+)+$");

        [SettingsProvider]
        public static SettingsProvider CreateSettingsProvider()
        {
            return new SettingsProvider("Project/Diannara/Gameplay Tags", SettingsScope.Project)
            {
                label = "Gameplay Tags",
                activateHandler = (searchContext, rootElement) =>
                {
                    GameplayTagSettings settings = GameplayTagSettings.instance;

                    VisualTreeAsset visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Diannara/GameplayTags/Editor/UI/GameplayTagSettings.uxml");
                    visualTree.CloneTree(rootElement);
                },
                keywords = new HashSet<string>(new[] { "Diannara", "Gameplay", "Tags" })
            };
        }

        [MenuItem("Diannara/Gameplay Tags/Settings", false, priority = 10)]
        public static void OpenGameplayTagsSettings()
        {
            SettingsService.OpenProjectSettings("Project/Diannara/Gameplay Tags");
        }
    }
}
