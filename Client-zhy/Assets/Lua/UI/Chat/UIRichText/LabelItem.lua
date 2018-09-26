local LabelItem = class("LabelItem")
function LabelItem:ctor(trs)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._label = trs:GetComponent("UILabel")

    --变量
    self._isShowed = false
    self._content = ""
    self._data = nil

    self:Hide()
end

function LabelItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function LabelItem:Show(data)
    self._data = data
    self:SetVisible(true)

end

function LabelItem:Hide()
    self:SetVisible(false)
    self._data = nil
end

return LabelItem