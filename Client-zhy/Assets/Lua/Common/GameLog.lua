--把用到的全局方法local下，避免了调用时查找全局表
local traceback = debug.traceback
local Utils = Utils

local function Log(format, ...)
    Utils.Log(traceback(string.format(format, ...)))
end

local function LogError(format, ...)
    Utils.LogError(traceback(string.format(format, ...)))
end

local function LogWarning(format, ...)
    Utils.LogWarning(traceback(string.format(format, ...)))
end

--执行逻辑的方法做成local的，在luajit里是受推荐的方式
--该种方法调用起来更快，少了table里的查找过程
GameLog = {}
GameLog.Log = Log
GameLog.LogError = LogError
GameLog.LogWarning = LogWarning