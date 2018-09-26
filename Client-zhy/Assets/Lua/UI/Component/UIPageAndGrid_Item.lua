-----------------------------UIPageAndGridItem-----------------------------
local UIPageAndGridItem = class("UIPageAndGridItem")
function UIPageAndGridItem:ctor(trs, funcOnClick)
    --组件
    self._transform = trs
    self._gameObject = trs.gameObject
    self._widget = trs:GetComponent("UIWidget")
    self._norGo = trs:Find("nor").gameObject
    self._specGo = trs:Find("spec").gameObject
    self._lis = UIEventListener.Get(self._gameObject)
    self._lis.onClick = UIEventListener.VoidDelegate(self.OnClick, self)
    
    self._funcOnClick = funcOnClick

    --变量
    self._isShowed = false
    self._data = nil
end

function UIPageAndGridItem:Init()
    self:ToNor()
    self:Hide()
end

function UIPageAndGridItem:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function UIPageAndGridItem:IsShowed()
    return self._isShowed
end

function UIPageAndGridItem:OnClick(eventData)
    if self._funcOnClick then
        self._funcOnClick(self._data.id)
    end
end

--用于继承
function UIPageAndGridItem:Show(data)
    self._data = data
    self:SetVisible(true)
end

function UIPageAndGridItem:Hide()
    self:SetVisible(false)
    self:ToNor()
    self._data = nil
end
--用于继承

--用于UIPageAndGrid组件调用
function UIPageAndGridItem:ToNor()
    self._specGo:SetActive(false)
    self._norGo:SetActive(true)
end

function UIPageAndGridItem:ToSpec()
    self._norGo:SetActive(false)
    self._specGo:SetActive(true)
end

function UIPageAndGridItem:GetId()
    return self._data.id
end
--用于UIPageAndGrid组件调用

return UIPageAndGridItem
-----------------------------UIPageAndGridItem-----------------------------