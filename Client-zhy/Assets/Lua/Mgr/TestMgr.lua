module("TestMgr", package.seeall)

local mEventItemList = {}

local function OnAddEquip()
    GameLog.LogError("TestMgr.OnAddEquip ->")
end

local function OnRemoveEquip()
    GameLog.LogError("TestMgr.OnRemoveEquip ->")
end

local function Init()
    table.insert(mEventItemList, EventMgr.EventItem.new(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Add, OnAddEquip))
    table.insert(mEventItemList, EventMgr.EventItem.new(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Remove, OnRemoveEquip))
end

Init()