local SpriteItem = class("SpriteItem")
function SpriteItem:ctor(trs)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._sprite = trs:GetComponent("UISprite")

    --变量
    self._isShowed = false
    self._data = nil

    self:Hide()
end

function SpriteItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function SpriteItem:Show(data)
    self._data = data
    self:SetVisible(true)
end

function SpriteItem:Hide()
    self:SetVisible(false)
    self._data = nil
end

return SpriteItem