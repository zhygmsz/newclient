module("TestMgr", package.seeall)

local function OnAddEquip()
    GameLog.LogError("TestMgr.OnAddEquip ->")
end

local function OnRemoveEquip()
    GameLog.LogError("TestMgr.OnRemoveEquip ->")
end

local function Init()
    EventMgr.Register(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Add, OnAddEquip)
    EventMgr.Register(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Remove, OnRemoveEquip)
end

Init()