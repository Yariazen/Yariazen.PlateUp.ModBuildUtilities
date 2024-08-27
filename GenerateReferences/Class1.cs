using Kitchen;
using KitchenData;
using KitchenMods;

namespace GenerateReferences
{
    public class GenerateReferencesSystem : GenericSystemBase, IModSystem
    {
        protected override void OnUpdate()
        {
            
        }

        protected override void Initialise()
        {
            Debug.Log("GenerateReferencesSystem Initialised");
            foreach (GameDataObject gdo in GameData.Main.Get<GameDataObject>())
            {
                Debug.Log(gdo.name);
            }
        }
    }
}
