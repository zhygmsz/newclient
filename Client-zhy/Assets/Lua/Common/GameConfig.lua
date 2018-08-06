local t = {}

local mFIndex = 0
local mSIndex = 0

local function GenFIndex()
    mFIndex = mFIndex + 1
    --重置次级索引
    mSIndex = 0
    return mFIndex
end

local function GenSIndex()
    mSIndex = mSIndex + 1
    return mSIndex
end

--定义各种事件类型
--
t.Event_F_Dialog = GenFIndex()
t.Event_S_Dialog_Open = GenSIndex()
t.Event_S_Dialog_Close = GenSIndex()

t.Event_F_Equip = GenFIndex()
t.Event_S_Equip_Add = GenSIndex()
t.Event_S_Equip_Remove = GenSIndex()

--
--
GameConfig = t

return GameConfig