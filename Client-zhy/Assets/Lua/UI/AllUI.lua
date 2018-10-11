module("AllUI", package.seeall)

--维护所有的界面
local mUIDataDic = {}



--[[
    @desc: 注册所有的UI，便于lua层维护
    --@uiId: UI的唯一id
	--@path: 和UI对应的lua文件的路径
]]
function RegisterUI(uiId, path)
    local uiName = string.match(path, ".+/(.+)")
    local luaScript = require(path)
    local uiData = {}
    uiData.uiId = uiId
    uiData.uiName = uiName
    uiData.luaScript = luaScript
    mUIDataDic[uiId] = uiData
end

function InitModule()
    
end

function GetUIData(uiId)
    if not uiId then
        return nil
    end
    return mUIDataDic[uiId]
end

return AllUI