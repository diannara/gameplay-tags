using UnityEditor;

namespace Diannara.GameplayTags.Editor
{
    [FilePath("ProjectSettings/GameplayTagSettings.asset", FilePathAttribute.Location.ProjectFolder)]
    public class GameplayTagSettings : ScriptableSingleton<GameplayTagSettings>
    {
        public string[] Tags;

        public void Save()
        {
            Save(true);
        }
    }
}
