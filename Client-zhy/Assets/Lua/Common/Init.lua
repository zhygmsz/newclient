--初始化非业务逻辑代码，独立模块
local function Init()
    require("Common/GameConfig")
    require("Common/GameLog")
    require("Common/GameUtils")
    require("Common/List")
    require("Common/EventMgr")
end

Init()
