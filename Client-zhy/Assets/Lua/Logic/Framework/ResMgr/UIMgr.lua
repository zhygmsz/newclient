module("UIMgr", package.seeall)

local xpcall = xpcall
local traceback = debug.traceback

--C#层的UIMgr
local mUIMgr = GameCore.UIMgr

--界面关闭后需要执行的回调信息，按需往里注册，生效一次，自动清理
local mInvokeDataOnClose = {}
--界面打开前回调信息，按需往里注册，生效一次，自动清理
local mInvokeDataOnOpen = {}

local function DoInvoke(uiID, funcName, ...)
    local success = false
    local uiData = AllUI.GetUIData(uiID)
    if uiData then
        if uiData.luaScript and uiData.luaScript[funcName] then
            local flag, errMsg = xpcall(uiData.luaScript[funcName], traceback, ...)
            if flag then
                --调用成功
                success = true
            else
                --输出调用堆栈错误
                GameLog.LogError(errMsg)
            end
        else
            GameLog.LogError("UIMgr.DoInvoke -> func is not exist, funcName = %s", funcName)
        end
    else
        GameLog.LogError("UIMgr.DoInvoke -> uiData is nil, uiID = %s", uiID)
    end
    return success
end

--以下是UI状态事件方法
local function OnCreate(uiID, frame)
    DoInvoke(uiID, "OnCreate", frame)
end

local function OnEnable(uiID, frame)
    local uiData = AllUI.GetUIData(uiID)
    if uiData then
        local success = false
        if uiData.args then
            success = DoInvoke(uiID, "OnEnable", frame, unpack(uiData.args))
        else
            success = DoInvoke(uiID, "OnEnable", frame)
        end
        if success then
            --继续OnEnable内额外的逻辑
            if uiData.func then
                local flag, errMsg
                if uiData.obj then
                    flag, errMsg = xpcall(uiData.func, traceback, uiData.obj)
                else
                    flag, errMsg = xpcall(uiData.func, traceback)
                end
                if not flag then
                    GameLog.LogError(errMsg)
                end
            end
        end
    else
        GameLog.LogError("UIMgr.OnEnable -> uiData is nil, uiID = %s", uiID)
    end
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

--[[
    @desc: 
    --@uiData:
	--@func: 回调
	--@obj: self
	--@hasArg: OnEnable时，是否传递参数
	--@args: 传递的参数，hasArg为true时有效
]]
function ShowUI(uiData, func, obj, hasArg, ...)
    if AllUI.CheckIsValid(uiData) then
        uiData.func = func
        uiData.obj = obj
        uiData.args = hasArg and {...} or nil

        --打开前回调
        DoInvokeFuncOnOpen(uiData)

        mUIMgr.ShowUI(uiData.uiID, uiData.uiName)
    else
        GameLog.LogError("UIMgr.ShowUI -> uiData is nil")
    end
end

function UnShowUI(uiData)
    if AllUI.CheckIsValid(uiData) then
        mUIMgr.UnShowUI(uiData.uiID)
        --关闭后回调
        DoInvokeFuncOnClose(uiData)
    else
        GameLog.LogError("UIMgr.UnShowUI -> uiData is nil")
    end
end

--[[
    @desc: 注册界面关闭后回调，执行一次，自动清理
    --@uiData:
	--@func:
	--@obj: 
]]
function RegInvokeDataOnClose(uiData, func, obj)
    local invokeData = mInvokeDataOnClose[uiData]
    if not invokeData then
        invokeData = {}
        mInvokeDataOnClose[uiData] = invokeData
    end
    invokeData.func = func
    invokeData.obj = obj
end

--[[
    @desc: 注册界面打开前回调，执行一次，自动清理
    --@uiData:
	--@func:
	--@obj: 
]]
function RegInvokeDataOnOpen(uiData, func, obj)
    local invokeData = mInvokeDataOnOpen[uiData]
    if not invokeData then
        invokeData = {}
        mInvokeDataOnOpen[uiData] = invokeData
    end
    invokeData.func = func
    invokeData.obj = obj
end

--[[
    @desc: 界面关闭时，试探性的调用，没有则不处理，又则执行回调
    执行完回调后，自动清理
    --@uiData: 
]]
function DoInvokeFuncOnClose(uiData)
    if not uiData then
        return
    end
    local invokeData = mInvokeDataOnClose[uiData]
    if not invokeData then
        return
    end

    if invokeData.func then
        if invokeData.obj then
            invokeData.func(invokeData.obj)
        else
            invokeData.func()
        end
    end

    --清理
    invokeData.func = nil
    invokeData.obj = nil
end

function DoInvokeFuncOnOpen(uiData)
    if not uiData then
        return
    end
    local invokeData = mInvokeDataOnOpen[uiData]
    if not invokeData then
        return
    end

    if invokeData.func then
        if invokeData.obj then
            invokeData.func(invokeData.obj)
        else
            invokeData.func()
        end
    end

    --清理
    invokeData.func = nil
    invokeData.obj = nil
end


return UIMgr