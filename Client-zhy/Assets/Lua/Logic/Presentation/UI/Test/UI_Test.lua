module("UI_Test", package.seeall)

local mSelf

local mSp1Trs

function OnCreate(self)
    GameLog.Log("---------------------OnCreate")
    mSp1Trs = self:Find("sp11111")
    local sp1Go = mSp1Trs.gameObject
    GameLog.LogError("sp1Go name = %s", sp1Go.name)
end

function OnEnable(self, myName, herName)
    GameLog.Log("---------------------OnEnable")
    if myName then
        GameLog.LogError(myName)
    end
    if herName then
        GameLog.LogError(herName)
    end
end

function OnDisable(self)
    GameLog.Log("---------------------OnDisable")
end

function OnDestroy(self)
    GameLog.Log("---------------------OnDestroy")
end

function OnClick(id)
    --GameLog.LogError("UI_Test.OnClick -> id = %s", id)
end

function OnPress(isPressed, id)
    --GameLog.LogError("UI_Test.OnPress -> id = %s, isPressed = %s", id, tostring(isPressed))
end

function OnSelect(selected, id)
    GameLog.LogError("UI_Test.OnSelect -> id = %s, selected = %s", id, tostring(selected))
end

function OnDoubleClick(id)
    GameLog.LogError("UI_Test.OnDoubleClick -> id = %s", id)
end

function OnDragStart(id)
    --GameLog.LogError("UI_Test.OnDragStart -> id = %s", id)
end

function OnDrag(delta, id)
    --GameLog.LogError("UI_Test.OnDrag -> id = %s, delta.x = %s, delta.y = %s", id, delta.x, delta.y)
end

function OnDragEnd(id)
    --GameLog.LogError("UI_Test.OnDragEnd -> id = %s", id)
end

function OnDragOver(obj, id)
    --GameLog.LogError("UI_Test.OnDragOver -> id = %s, obj.name = %s", id, obj.name)
end

function OnDragOut(obj, id)
    --GameLog.LogError("UI_Test.OnDragOut -> id = %s, obj.name = %s", id, obj.name) 
end