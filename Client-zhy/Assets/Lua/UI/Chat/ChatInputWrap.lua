--以下两个类需要用的枚举，标识文本或语音状态
local LabelOrVoice = {}
LabelOrVoice.None = -1
LabelOrVoice.Label = 1
LabelOrVoice.Voice = 2

--------------------------------ToggleItem--------------------------------
local ToggleItem = class("ToggleItem")
function ToggleItem:ctor(trs, funcOnClick)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._voiceGo = trs:Find("Voice").gameObject
    self._labelGo = trs:Find("Label").gameObject
    
    self._lis = UIEventListener.Get(self._gameObject)
    self._lis.onClick = UIEventListener.VoidDelegate(self.OnClick, self)

    self._funcOnClick = funcOnClick

    --变量
    --处于label状态还是voice状态，默认为label状态
    self._labelOrVoice = LabelOrVoice.None

    self:Reset(LabelOrVoice.Label)
end

function ToggleItem:Switch()
    self._labelGo:SetActive(self._labelOrVoice == LabelOrVoice.Label)
    self._voiceGo:SetActive(self._labelOrVoice == LabelOrVoice.Voice)
end

--==============================--
--desc:界面打开时，设置默认状态
--@labelOrVoice:
--==============================--
function ToggleItem:Reset(labelOrVoice)
    self._labelOrVoice = labelOrVoice
    self:Switch()
end

function ToggleItem:Change()
    if self._labelOrVoice == LabelOrVoice.Label then
        self._labelOrVoice = LabelOrVoice.Voice
    elseif self._labelOrVoice == LabelOrVoice.Voice then
        self._labelOrVoice = LabelOrVoice.Label
    end
end

function ToggleItem:OnClick(eventData)
    --内部处理状态
    self:Change()
    self:Switch()

    --向外抛出状态
    if self._funcOnClick then
        self._funcOnClick(self._labelOrVoice)
    end
end
--------------------------------ToggleItem--------------------------------

--公用输入框
local ChatInputWrap = class("ChatInputWrap")
ChatInputWrap.LabelOrVoice = LabelOrVoice

--------------------------------ChatInputWrap--------------------------------
--==============================--
--desc:
--@trs:
--@limitCount:输入框最大输入数量
--@openType:详见ChatMgr_Main文件的CommonLinkOpenType枚举类型
--==============================--
function ChatInputWrap:ctor(trs, limitCount, roomType, openType)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._voiceRoot = trs:Find("VoiceRoot").gameObject
    self._inputRoot = trs:Find("InputRoot").gameObject
    
    self._funcOnToggle = function(labelOrVoice)
        self:OnToggle(labelOrVoice)
    end
    self._toggleTrs = trs:Find("Toggle")
    self._toggleItem = ToggleItem.new(self._toggleTrs, self._funcOnToggle)

    --input
    self._input = trs:Find("InputRoot/Input"):GetComponent("UIInput")
    self._input.useDefaultAlign = false
    self:ResetLimitCount(limitCount)

    self._funcOnNewLinkData = function(linkType, linkData)
        self:OnNewLinkData(linkType, linkData)
    end

    self._funcOnTextChange = EventDelegate.Callback(self.OnTextChange, self)
    EventDelegate.Set(self._input.onChange, self._funcOnTextChange)

    --Chat_pb.ChatMsgCommon
    self._roomType = roomType
    self._msgCommon = Chat_pb.ChatMsgCommon()
    self._msgCommon.roomType = self._roomType

    --表情按钮
    self._linkGo = trs:Find("InputRoot/Link").gameObject
    self._linkLis = UIEventListener.Get(self._linkGo)
    self._linkLis.onClick = UIEventListener.VoidDelegate(self.OnLinkBtnClick, self)

    --发送按钮
    self._sendGo = trs:Find("InputRoot/Send").gameObject
    self._sendLis = UIEventListener.Get(self._sendGo)
    self._sendLis.onClick = UIEventListener.VoidDelegate(self.OnSendBtnClick, self)
    
    --对外
    self._openType = openType

    --变量
    self._labelOrVoice = LabelOrVoice.None

    self:Reset(LabelOrVoice.Label)
end

function ChatInputWrap:OnSendBtnClick(eventData)
    --发送消息
end

function ChatInputWrap:OnLinkBtnClick(eventData)
    --ChatInputWrap脚本有多个，但在某时刻,能响应UI_Chat_CommonLink界面超链接数据的只有一个
    ChatMgr.OpenCommonLinkByType(self._openType, self._funcOnNewLinkData)
end

--------------------------------input--------------------------------
function ChatInputWrap:GetMsgCommon()
    self._msgCommon.roomType = self._roomType
    return self._msgCommon
end

function ChatInputWrap:ResetRoom(roomType)
    self._roomType = roomType
end

--==============================--
--desc:重置输入框状态，每次发送完消息调用
--==============================--
function ChatInputWrap:ResetInput()
    self._input:RemoveFocus()
    self._input.value = ""
    self._msgCommon = Chat_pb.ChatMsgCommon()
end

function ChatInputWrap:ResetLimitCount(limitCount)
    self._limitCount = limitCount
    self._input.characterLimit = self._limitCount
end

function ChatInputWrap:OnTextChange()
    
end
--------------------------------input--------------------------------

--------------------------------toggle--------------------------------
--==============================--
--desc:来自ToggleItem回调
--@labelOrVoice:
--==============================--
function ChatInputWrap:OnToggle(labelOrVoice)
    self._labelOrVoice = labelOrVoice
    self:Switch()
end

function ChatInputWrap:Switch()
    self._inputRoot:SetActive(self._labelOrVoice == LabelOrVoice.Label)
    self._voiceRoot:SetActive(self._labelOrVoice == LabelOrVoice.Voice)
end

--==============================--
--desc:界面打开时，设置默认状态，有些界面可能需要打开时默认选中语音状态
--@labelOrVoice:
--==============================--
function ChatInputWrap:Reset(labelOrVoice)
    --初始化，保持一致化
    self._labelOrVoice = labelOrVoice
    self:Switch()
    self._toggleItem:Reset(labelOrVoice)
end
--------------------------------toggle--------------------------------

--------------------------------对外--------------------------------
--==============================--
--desc:新链接数据
--@linkType:
--@linkData:
--==============================--
function ChatInputWrap:OnNewLinkData(linkType, linkData)

end
--------------------------------外部交互--------------------------------

return ChatInputWrap
--------------------------------ChatInputWrap--------------------------------