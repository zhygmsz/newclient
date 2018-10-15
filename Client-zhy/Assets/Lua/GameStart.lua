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
	--打开第一个UI，测试UI框架
	UIMgr.ShowUI(AllUI.UI_Test)
end