local function InitDebug()
	require("Logic/Framework/ToLua/debug/" .. (jit and "LuaDebugjit" or "LuaDebug"))("localhost", 7003)
end

local function InitCommon()
	--日志（直接调用cs）
	require("Logic/Framework/Common/GameLog")

	--类构造器
	require("Logic/Framework/Common/Class")

	--资源管理
	require("Logic/Framework/ResMgr/ResMgr").Init()

	--UI管理
	require("Logic/Framework/ResMgr/UIMgr").Init()
	require("Logic/Presentation/UI/Define/AllUI").Init()
end

local function InitLogic()
	require("Logic/GameInit/GameInit").Init()
end

local function Init()
	InitDebug()

	InitCommon()

	InitLogic()
end

--[[
    @desc: lua逻辑根节点，由C#发起调用
]]
function Start()
	print("GameStart.Start -> ")

	Init()

	--测试
	Test()
end

function Test()
	--打开第一个UI，测试UI框架
	UIMgr.ShowUI(AllUI.UI_Test)
end