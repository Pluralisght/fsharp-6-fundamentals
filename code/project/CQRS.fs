module Project.CQRS

type Id = string
type Name = string
type Amount = int
type Command = 
    | CreateInventoryItem of Id
    | RenameInventoryItem of Id * Name
    | RemoveItemsFromInventory of Id * Amount
    | AddItemsToInventory of Id * Amount
    | DeactivateInventoryItem of Id
type Event  = 
    | InventoryItemCreated of Id
    | InventoryItemRenamed of Id * Name
    | ItemsRemovedFromInventory of Id * Amount
    | ItemsCheckedInToInventory of Id * Amount
    | InventoryItemDeactivated of Id
type Item = { itemId : Id; activated : bool }

// NOTE: use Chessie or F# 4.1 instead
let handle command someItem = 

    match someItem, command with
    | None,      CreateInventoryItem ID -> Ok [ InventoryItemCreated ID ]
    | None, _ -> Error "please create the item first"
    | Some item, CreateInventoryItem ID -> Error "item already created"
    | Some item, DeactivateInventoryItem ID -> 
        if item.activated then Ok [InventoryItemDeactivated ID] else Error "already deactivated"
    | Some item, _ when not item.activated -> Error "item is deactivated"
    | Some item, RenameInventoryItem (ID, name) -> 
        if System.String.IsNullOrEmpty name then Error "invalid name"
        else Ok [InventoryItemRenamed (ID, name) ]
    | Some item, RemoveItemsFromInventory(ID, amount) ->
        if amount <= 0 then Error "Can't remove negative amoutn from inventory"
        else Ok [ItemsRemovedFromInventory (ID, amount)]
    | Some item, AddItemsToInventory(ID, amount) ->
        if amount <= 0 then Error "must have an amount > 0 to checkin to inventory"
        else Ok [ItemsCheckedInToInventory(ID,amount)]

let applyEvent someItem event =
    match someItem, event with
    | None, InventoryItemCreated ID -> Some { itemId = ID; activated = true}
    | Some item, InventoryItemDeactivated ID -> Some {item with activated = false }
    | Some item, _ -> Some item
    | None, _ -> None
let applyEvents = List.fold applyEvent