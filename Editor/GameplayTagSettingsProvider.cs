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

                    Label titleLabel = new Label("Diannara's Gameplay Tags");
                    titleLabel.style.fontSize = 20;
                    titleLabel.style.unityFontStyleAndWeight = FontStyle.Bold;
                    titleLabel.style.marginBottom = 10;
                    titleLabel.style.marginLeft = 10;
                    titleLabel.style.marginTop = 10;
                    rootElement.Add(titleLabel);

                    Label descriptionLabel = new Label("Define the tags that can be used in the game.");
                    descriptionLabel.style.marginLeft = 10;
                    descriptionLabel.style.marginBottom = 15;
                    rootElement.Add(descriptionLabel);

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
