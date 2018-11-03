module("UIMgr", package.seeall)

--C#层的UIMgr
local mUIMgr = GameCore.UIMgr

local function DoInvoke(uiID, funcName, ...)
    local uiData = AllUI.GetUIData(uiID)
    if uiData then
        if uiData.luaScript and uiData.luaScript[funcName] then
            uiData.luaScript[funcName](...)
        else
            GameLog.LogError("UIMgr.DoInvoke -> func is not exist, funcName = %s", funcName)
        end
    else
        GameLog.LogError("UIMgr.DoInvoke -> uiData is nil, uiID = %s", uiID)
    end
end

--以下是UI状态事件方法
local function OnCreate(uiID, frame)
    DoInvoke(uiID, "OnCreate", frame)
end

local function OnEnable(uiID, frame)
    DoInvoke(uiID, "OnEnable", frame)
end

local function OnDisable(uiID, frame)
    DoInvoke(uiID, "OnDisable", frame)
end

local function OnDestroy(uiID, frame)
    DoInvoke(uiID, "OnDestroy", frame)
end

--以下是NGUI事件方法
local function OnClick(uiID, eventID)
    DoInvoke(uiID, "OnClick", eventID)
end

local function OnPress(uiID, isPressed, eventID)
    DoInvoke(uiID, "OnPress", isPressed, eventID)
end

local function OnSelect(uiID, selected, eventID)
    DoInvoke(uiID, "OnSelect", selected, eventID)
end

local function OnDoubleClick(uiID, eventID)
    DoInvoke(uiID, "OnDoubleClick", eventID)
end

local function OnDragStart(uiID, eventID)
    DoInvoke(uiID, "OnDragStart", eventID)
end

local function OnDrag(uiID, delta, eventID)
    DoInvoke(uiID, "OnDrag", delta, eventID)
end

local function OnDragEnd(uiID, eventID)
    DoInvoke(uiID, "OnDragEnd", eventID)
end

local function OnDragOver(uiID, obj, eventID)
    DoInvoke(uiID, "OnDragOver", obj, eventID)
end

local function OnDragOut(uiID, obj, eventID)
    DoInvoke(uiID, "OnDragOut", obj, eventID)
end

function Init()
    --可能还需要UIRoot作为根节点，放置新创建的UI
    mUIMgr.Init(OnCreate, OnEnable, OnDisable, OnDestroy,
            OnClick, OnPress, OnSelect,
            OnDoubleClick,
            OnDragStart, OnDrag, OnDragEnd, OnDragOver, OnDragOut)

    --

end

--UI打开的处理过程为异步后，需要再传递一个回调
--这个回调在lua层由统一的地方管理，业务逻辑层只需用uiID和一个lua方法即可注册
function ShowUI(uiData)
    if AllUI.CheckIsValid(uiData) then
        mUIMgr.ShowUI(uiData.uiID, uiData.uiName)
    else
        GameLog.LogError("UIMgr.ShowUI -> uiData is nil")
    end
end

function UnShowUI(uiData)
    if AllUI.CheckIsValid(uiData) then
        mUIMgr.UnShowUI(uiData.uiID)
    else
        GameLog.LogError("UIMgr.UnShowUI -> uiData is nil")
    end
end

return UIMgr