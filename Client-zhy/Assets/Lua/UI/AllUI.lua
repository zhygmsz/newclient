module("AllUI", package.seeall)

local mUIDataDic = {}
AllUI.UIData = mUIDataDic
local mUIDataDicForCS = {}

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
    local luaScript = require(path)
    local uiData = {}
    local uiId = GenUIID()
    --uiID主要用于和C#建立对应关系，因为C#层的UI字典key为uiID
    --而C#层使用的uiID也正是来自这个方法里
    uiData.uiId = uiId
    --在Lua层,UI字典的key为uiName
    uiData.uiName = uiName
    uiData.luaScript = luaScript
    --为了能AllUI.UIData.uiName的形式获取UI数据
    mUIDataDic[uiName] = uiData
    mUIDataDicForCS[uiId] = uiData
end

function InitModule()
    require("UI.Define.TestDefine")
end

function GetUIData(uiId)
    if not uiId then
        return nil
    end
    return mUIDataDicForCS[uiId]
end

return AllUI