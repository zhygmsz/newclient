module("TestMgr", package.seeall)

local mEventList

local function OnAddEquip()
    GameLog.LogError("TestMgr.OnAddEquip ->")
end

local function OnRemoveEquip()
    GameLog.LogError("TestMgr.OnRemoveEquip ->")
end

function Init()
    mEventList = EventMgr.EventList.new()
    mEventList:Register(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Add, OnAddEquip)
    mEventList:Register(GameConfig.Event_F_Equip, GameConfig.Event_S_Equip_Remove, OnRemoveEquip)
end

return TestMgr