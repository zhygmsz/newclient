module("UI_Test", package.seeall)

function OnCreate(self)
    GameLog.Log("---------------------OnCreate")
end

function OnEnable(self)
    GameLog.Log("---------------------OnEnable")
end

function OnDisable(self)
    GameLog.Log("---------------------OnDisable")
end

function OnDestroy(self)
    GameLog.Log("---------------------OnDestroy")
end

function OnClick(id)
    GameLog.LogError("UI_Test.OnClick -> id = %s", id)
end

function OnPress(isPressed, id)
    GameLog.LogError("UI_Test.OnPress -> id = %s, isPressed = %s", id, isPressed)
end

function OnSelect(selected, id)
    GameLog.LogError("UI_Test.OnSelect -> id = %s, selected = %s", id, selected)
end

function OnDoubleClick(id)
    GameLog.LogError("UI_Test.OnDoubleClick -> id = %s", id)
end

function OnDragStart(id)
    GameLog.LogError("UI_Test.OnDragStart -> id = %s", id)
end

function OnDrag(delta, id)
    GameLog.LogError("UI_Test.OnDrag -> id = %s, delta.x = %s, delta.y = %s", id, delta.x, delta.y)
end

function OnDragEnd(id)
    GameLog.LogError("UI_Test.OnDragEnd -> id = %s", id)
end

function OnDragOver(obj, id)
    
end

function OnDragOut(obj, id)
    
end