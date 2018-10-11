local function InitGame()
	require("GameInit").Init()
end

local function InitDebug()
	require("DebugSystem.DebugHelper").Init()
end

--[[
    @desc: lua逻辑根节点，由C#发起调用
]]
function Start()
	print("GameStart.Start -> ")

	InitDebug()
	InitGame()

	--测试
	Test()
end

function Test()
	EventMgr.Send(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Add)
end