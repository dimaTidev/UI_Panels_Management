 # Unity UI_Panels_Management
Simple UI management system: 
 - Add New panel automatic hide previous. 
 - Redo Automatic hide current panel and show previous
 
 # How Panel Manager works:
* Add `PanelManager_broker.cs` to main panel (This `PanelManager_broker.cs` at start clened panel history and add himself to manager like mainPanel)
* For GoTo panel: Add to UnityEvent as parameter - `Panel_Manager.asset/GoTo(GameObject)` (ScriptableObject)
* For Redo panel: Add to UnityEvent as parameter - `Panel_Manager/asset.Redo()` (ScriptableObject)


 # How Panel Hiding works:
* Use `PanelHider_Executor.cs` + `PanelHide_Event.cs` + `PanelHider_Broker.cs`
* `PanelHider_Broker.cs` - subscribe to event in `PanelHide_Event.cs`
* `PanelHider_Executor.cs` - execute event in `PanelHide_Event.cs`

Contains 3 Samples.
