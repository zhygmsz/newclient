module("UI_Chat_Main", package.seeall)

local mSelf

local mSerializedStr

function OnCreate(self)
    mSelf = self

    local msgCommon = Chat_pb.ChatMsgCommon()
    msgCommon.content = "图文混排开始了，你们都是自寻死路"
    mSerializedStr = msgCommon:SerializeToString()
end

function OnEnable(self)
    local msgCommon =  Chat_pb.ChatMsgCommon()
    msgCommon:ParseFromString(mSerializedStr)
    GameLog.LogError("msgCommon.content = %s", msgCommon.content)
end

function OnDisable(self)

end

function OnDestroy(self)

end

function OnClick(id)

end