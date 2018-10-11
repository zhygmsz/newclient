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
    local luaScript = require(path)
    local uiData = {}
    local uiId = GenUIID()
    uiData.uiId = uiId
    uiData.uiName = uiName
    uiData.luaScript = luaScript
    mUIDataDic[uiId] = uiData
end

function InitModule()
    require("UI.Define.TestDefine")
end

function GetUIData(uiId)
    if not uiId then
        return nil
    end
    return mUIDataDic[uiId]
end

return AllUI