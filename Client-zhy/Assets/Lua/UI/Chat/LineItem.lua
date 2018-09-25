local LineItem = class("LineItem")
function LineItem:ctor(trs)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._widget = trs:GetComponent("UIWidget")

    --变量
    self._isShowed = false
    self._data = nil
    self._labelItemList = {}
    self._spriteItemList = {}

    self:Hide()
end

function LineItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function LineItem:Show(data)
    self._data = data
    self:SetVisible(true)
end

function LineItem:Hide()
    self:SetVisible(false)
    self._data = nil
    self._labelItemList = {}
    self._spriteItemList = {}
end

return LineItem