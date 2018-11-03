-----------------------------UIPageAndGridWidget-----------------------------
local UIPageAndGridWidget = class("UIPageAndGridWidget")
function UIPageAndGridWidget:ctor(trs, ui)
    --组件
    self._ui = ui
    self._transform = trs
    self._gameObject = trs.gameObject
    --该控件由派生类根据自身路径去获取
    self._svTrs = nil

    --变量
    self._isShowed = false

    --以下两个数据由派生类获取
    self._dataDic = nil
    self._numPerPage = 0

    self._funcOnItemClick = function(id)
        self:OnItemClick(id)
    end

    --由派生类根据自己的Item和numPerPage创建
    self._pageAndGrid = nil

    self._curItemId = -1
end

function UIPageAndGridWidget:SetItemToNor(id)
    self._pageAndGrid:SetItemToNor(id)
end

function UIPageAndGridWidget:SetItemToSpec(id)
    self._pageAndGrid:SetItemToSpec(id)
end

function UIPageAndGridWidget:OnItemClick(id)
    if not id then
        return
    end
    if self._curItemId == id then
        self:OnSameIdClick()
        return
    end

    self:SetItemToNor(self._curItemId)
    self._curItemId = id
    self:SetItemToSpec(self._curItemId)
end

function UIPageAndGridWidget:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

--用于继承
function UIPageAndGridWidget:Show()
    self:SetVisible(true)
end

function UIPageAndGridWidget:Hide()
    self:SetVisible(false)
    self:SetItemToNor(self._curItemId)
    self._curItemId = -1
end

--点击同一个item回调，可能会用来做提示
function UIPageAndGridWidget:OnSameIdClick()

end
--用于继承

return UIPageAndGridWidget
-----------------------------UIPageAndGridWidget-----------------------------
