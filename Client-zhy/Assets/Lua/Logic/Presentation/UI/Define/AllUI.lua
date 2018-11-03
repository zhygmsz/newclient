module("AllUI", package.seeall)

local mUIDataDic = {}

local mUIID = 0
local function GenUIID()
    mUIID = mUIID + 1
    return mUIID
end

--[[
    @desc: 注册所有的UI，便于lua层维护
	--@path: 和UI对应的lua文件的路径
]]
function RegisterUI(path)
    local uiName = string.match(path, ".+/(.+)")
    require(path)
    local luaScript = package.loaded[uiName]
    local uiData = {}
    local uiID = GenUIID()
    --uiID主要用于和C#建立对应关系，因为C#层的UI字典key为uiID
    --而C#层使用的uiID也正是来自这个方法里
    uiData.uiID = uiID
    --在Lua层,UI字典的key为uiName
    uiData.uiName = uiName
    uiData.luaScript = luaScript
    --为了能AllUI.UIData.uiName的形式获取UI数据
    AllUI[uiName] = uiData
    mUIDataDic[uiID] = uiData
end

function GetUIData(uiID)
    if not uiID then
        return nil
    end
    return mUIDataDic[uiID]
end

function CheckIsValid(uiData)
    if uiData and uiData.uiID then
        uiData = mUIDataDic[uiData.uiID]
        if uiData then
            return true
        else
            return false
        end
    else
        return false
    end
end

local function InitDefine()
    require("Logic/Presentation/UI/Define/TestDefine")
    require("Logic/Presentation/UI/Define/UISystemDefine")
end

function Init()
    --一次性注册所有的UI
    InitDefine()
end

return AllUI