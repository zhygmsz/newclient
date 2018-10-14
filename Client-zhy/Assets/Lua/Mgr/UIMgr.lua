module("UIMgr", package.seeall)

function Init()
    
end

--UI打开的处理过程为异步后，需要再传递一个回调
--这个回调由统一的地方管理，业务逻辑层只需用uiID和一个lua方法即可注册
function ShowUI(uiID)
    
end

function UnShowUI(uiID)
    
end

--以下是UI状态事件方法
function OnCreate(uiID, frame)
    
end

function OnEnable(uiID, frame)
end

function OnDisable(uiID, frame)
    
end

function OnDestroy(uiID, frame)
end

--以下是NGUI事件方法
function OnClick(uiID, eventID)
end

function OnPress(uiID, isPressed, eventID)
end

function OnSelect(uiID, selected, eventID)
end

function OnDoubleClick(uiID, eventID)
end

function OnDragStart(uiID, eventID)
end

function OnDrag(uiID, delta, eventID)
end

function OnDragEnd(uiID, eventID)
end

function OnDragOver(uiID, obj, eventID)
end

function OnDragOut(uiID, obj, eventID)
    
end

return UIMgr