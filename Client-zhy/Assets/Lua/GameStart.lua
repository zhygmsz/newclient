local function InitGame()
	require("GameInit")
end

local function InitDebug()
	require("DebugSystem/DebugHelper")
	DebugHelper.Init()
end

--lua控制权根节点
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