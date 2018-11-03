module("EventMgr", package.seeall)

local TryCatch = GameUtils.TryCatch

local pool = {}

local function Register(first, second, func, self)
    if type(first) ~= "number" or type(second) ~= "number" then
        GameLog.LogError("EventMgr.Register -> first, second must be integer")
        return -1
    end

    if type(func) ~= "function" then
        GameLog.LogError("EventMgr.Register -> func must be a function")
        return -2
    end

    local temp = pool[first]
    if temp == nil then
        temp = {}
        pool[first] = temp
    end
    
    local list = temp[second]
    if list == nil then
        list = List()
        temp[second] = list
    end

    if list.Count() > 100 then
        GameLog.LogError("EventMgr.Register -> event to munch, %d, %d", first, second)
    end

    for i = 1, list.Count() do
        local xx = list.Get(i)
        if xx ~= nil and xx.func == func and xx.self == self then
            GameLog.LogError("EventMgr.Register -> event has already be registered, %d, %d", first, second)
            return -3
        end
    end

    local tt = {}
    tt.func = func
    tt.self = self
    return list.RandAdd(tt)
end

local function UnRegister(first, second, index)
    if type(first) ~= "number" or type(second) ~= "number" then
        GameLog.LogError("EventMgr.UnRegister -> first, second must be integer")
        return
    end

    if index == nil or type(index) ~= "number" then
        GameLog.LogError("EventMgr.UnRegister -> index must be not nil and must be a integer")
        return
    end

    local temp = pool[first]
    if temp ~= nil then
        local list = temp[second]
        if list ~= nil then
            list.Remove(index)
        end
    end
end

function Send(first, second, ...)
    if type(first) ~= "number" or type(second) ~= "number" then
        GameLog.LogError("EventMgr.Send -> first, second must be integer")
        return
    end

    local temp = pool[first]
    if temp == nil then
        return
    end

    local list = temp[second]
    if list == nil then
        return
    end

    local listCount = list.Count()
    local tt
    for i = 1, listCount do
        tt = list.Get(i)
        if tt ~= nil then
            if tt.self ~= nil then
                if TryCatch(tt.func, tt.self, ...) == false then
                    GameLog.LogError("EventMgr.Send -> invoke error, %d, %d, %s", first, second, tostring(tt.func))
                end
            else
                if TryCatch(tt.func, ...) == false then
                    GameLog.LogError("EventMgr.Send -> invoke error, %d, %d, %s", first, second, tostring(tt.func))
                end
            end
        end
    end
end

local EventItem = class("EventItem")
function EventItem:ctor(firstIdx, secondIdx, func, selfObj)
    self._firstIdx = firstIdx
    self._secondIdx = secondIdx
    self._func = func
    self._selfObj = selfObj

    self._index = -1

    self:Register()
end

function EventItem:Register()
    self._index = Register(self._firstIdx, self._secondIdx, self._func, self._selfObj)
end

function EventItem:UnRegister()
    UnRegister(self._firstIdx, self._secondIdx, self._index)
end

EventList = class("EventList")
function EventList:ctor()
    self._list = {}
end

function EventList:Register(firstIdx, secondIdx, func, selfObj)
    table.insert(self._list, EventItem.new(firstIdx, secondIdx, func, selfObj))
end

function EventList:UnRegisterAll()
    for _, eventItem in ipairs(self._list) do
        if eventItem then
            eventItem:UnRegister()
        end
    end
end