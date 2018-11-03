local RichTextItem = class("RichTextItem")
function RichTextItem:ctor(trs)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._widget = trs:GetComponent("UIWidget")

    --变量
    self._isShowed = false
    self._data = nil
    self._lineItemList = {}

    self:Hide()
end

function RichTextItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function RichTextItem:Show(data)
    self._data = data
    self:SetVisible(true)
end

function RichTextItem:Hide()
    self:SetVisible(false)
    self._data = nil
    self._lineItemList = {}
end

return RichTextItem