local function InitCommon()
    require("Common/Init")
end

local function InitMgr()
    require("Mgr/Init")
end

--初始化业务逻辑代码
local function Init()
    InitCommon()
    InitMgr()
end

Init()