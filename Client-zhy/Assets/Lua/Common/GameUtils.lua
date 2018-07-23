local xpcall = xpcall
local traceback = debug.traceback
local print = print
local GameLog = GameLog

local function TryCatch(func, ...)
	local ret, errmsg = xpcall(func, traceback, ...)
	if errmsg then
        GameLog.LogError("call func error -> %s", errmsg)
		return false
	end
	return true
end

local function Split(str, delimiter)
	if str == nil or str == '' or delimiter == nil then
		return nil
	end
	
	local result = {}
	for match in(str .. delimiter):gmatch("(.-)" .. delimiter) do
		table.insert(result, match)
	end
	return result
end

GameUtils = {}
GameUtils.TryCatch = TryCatch
GameUtils.Split = Split