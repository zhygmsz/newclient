module("UIMgr", package.seeall)

--C#层的UIMgr
local mUIMgr = GameCore.UIMgr

--以下是UI状态事件方法
local function OnCreate(uiID, frame)
    
end

local function OnEnable(uiID, frame)
end

local function OnDisable(uiID, frame)
    
end

local function OnDestroy(uiID, frame)
end

--以下是NGUI事件方法
local function OnClick(uiID, eventID)
end

local function OnPress(uiID, isPressed, eventID)
end

local function OnSelect(uiID, selected, eventID)
end

local function OnDoubleClick(uiID, eventID)
end

local function OnDragStart(uiID, eventID)
end

local function OnDrag(uiID, delta, eventID)
end

local function OnDragEnd(uiID, eventID)
end

local function OnDragOver(uiID, obj, eventID)
end

local function OnDragOut(uiID, obj, eventID)
    
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
        --uiData无效，提示
    end
end

function UnShowUI(uiData)
    if AllUI.CheckIsValid(uiData) then
        mUIMgr.UnShowUI(uiData.uiID)
    else
        --uiData无效，提示
    end
end

return UIMgr