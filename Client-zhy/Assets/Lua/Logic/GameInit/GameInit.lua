module("GameInit", package.seeall)

--[[
    @desc: 初始化非业务逻辑代码，独立模块
]]
local function InitCommon()
    --基础服务
    require("Logic/Framework/Common/GameConfig")
    require("Logic/Framework/Common/GameUtils")

    --pb文件加载
    require("Logic/Proto/AllPB").Init()
    
    --容器
    require("Logic/Framework/Container/List")

    --事件管理（用到了GameUtils/List内的方法）
    require("Logic/Event/EventMgr")
    
    --
    require("Logic/GameInit/GameInitSystem")
end

--初始化业务逻辑代码
function Init()
    InitCommon()

    InitSystem()
end

return GameInit