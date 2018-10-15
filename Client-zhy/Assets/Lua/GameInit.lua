module("GameInit", package.seeall)

--[[
    @desc: 初始化非业务逻辑代码，独立模块
]]
local function InitCommon()
    require("Common/GameConfig")
    require("Common/GameLog")
    require("Common/GameUtils")
    require("Common/List")
    require("Common/Class")
    require("Common/EventMgr")

    require("UI.AllUI").Init()
end

--[[
    @desc: 各个逻辑模块对应的数据管理部分
]]
local function InitMgr()
    require("Mgr.UIMgr").Init()
    require("Mgr.TestMgr").Init()
end

--初始化业务逻辑代码
function Init()
    InitCommon()
    InitMgr()
end

return GameInit