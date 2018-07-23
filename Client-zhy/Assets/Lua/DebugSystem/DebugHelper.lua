local M = {}

function M.Init(host, port)
    M.StartLuaDebugger(host, port)
end

function M.StartLuaDebugger(host, port)
    local DEBUGGER_FILE = "LuaDebug"
    if jit then
        DEBUGGER_FILE = "LuaDebugjit"
    end

    require("DebugSystem/" .. DEBUGGER_FILE)(host or "localhost", port or 7003)
end

--全局
DebugHelper = M