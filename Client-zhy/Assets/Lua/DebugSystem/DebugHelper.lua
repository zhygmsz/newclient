module("DebugHelper", package.seeall)

function Init(host, port)
    StartLuaDebugger(host, port)
end

function StartLuaDebugger(host, port)
    local DEBUGGER_FILE = "LuaDebug"
    if jit then
        DEBUGGER_FILE = "LuaDebugjit"
    end

    require("DebugSystem/" .. DEBUGGER_FILE)(host or "localhost", port or 7003)
end

return DebugHelper