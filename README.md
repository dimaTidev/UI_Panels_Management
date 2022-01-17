 # Unity UI_Panels_Management
Simple UI management system: 
 - Add New panel automatic hide previous. 
 - Redo Automatic hide current panel and show previous
 
 # How it works
* Add `Panel_broker.cs` to main panel (This `Panel_broker.cs` at start clened panel history and add himself to manager like mainPanel)
* For GoTo panel: Add to UnityEvent as parameter - `Panel_Manager.asset/GoTo(GameObject)` (ScriptableObject)
* For Redo panel: Add to UnityEvent as parameter - `Panel_Manager/asset.Redo()` (ScriptableObject)
