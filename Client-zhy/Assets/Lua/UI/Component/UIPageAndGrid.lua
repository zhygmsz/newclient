-----------------------------Page-----------------------------
local Page = class("Page")
function Page:ctor(trs, ui, Item, numPerPage, funcOnClick)
    --组件
    self._ui = ui
    self._transform = trs
    self._gameObject = trs.gameObject
    self._itemTemp = trs:Find("item")
    self._itemTemp.gameObject:SetActive(false)
    self._gridTrs = trs:Find("grid")
    self._grid = self._gridTrs:GetComponent("UIGrid")
    self._grid.enabled = false

    --self._itemTemp对应的组件
    self._Item = Item
    self._funcOnClick = funcOnClick

    --变量
    self._isShowed = false
    self._dataList = {}
    self._itemList = {}
    self._numPerPage = numPerPage
    self._originPos = self._gridTrs.localPosition

    self:InitItemList()

    self:Hide()
end

function Page:InitItemList()
    local trs = nil
    for idx = 1, self._numPerPage do
        trs = self._ui:DuplicateAndAdd(self._itemTemp, self._gridTrs, 0)
        trs.name = "item" .. tostring(idx)
        self._itemList[idx] = self._Item.new(trs, self._funcOnClick)
    end
end

function Page:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function Page:IsShowed()
    return self._isShowed
end

function Page:Show(dataList)
    self._dataList = dataList
    self:SetVisible(true)

    local data = nil
    for idx, item in ipairs(self._itemList) do
        data = self._dataList[idx]
        if data then
            item:Show(data)
        else
            item:Hide()
        end
    end

    self._grid:Reposition()
    self._gridTrs.localPosition = self._originPos
end

function Page:Hide()
    self:SetVisible(false)
end

function Page:SetItemToNor(id)
    for _, item in ipairs(self._itemList) do
        if item and item:IsShowed() and item:GetId() == id then
            item:ToNor()
        end
    end
end

function Page:SetItemToSpec(id)
    for _, item in ipairs(self._itemList) do
        if item and item:IsShowed() and item:GetId() == id then
            item:ToSpec()
        end
    end
end
-----------------------------Page-----------------------------


-----------------------------UIPageAndGrid-----------------------------
local UIPageAndGrid = class("UIPageAndGrid")
function UIPageAndGrid:ctor(trs, ui, Item, numPerPage, funcOnClick)
    --组件
    self._ui = ui
    self._Item = Item
    self._funcOnClick = funcOnClick

    self._transform = trs
    self._gameObject = trs.gameObject
    self._pageTemp = trs:Find("page")
    self._pageTemp.gameObject:SetActive(false)
    self._gridTrs = trs:Find("grid")
    self._grid = self._gridTrs:GetComponent("UIGrid")
    self._grid.enabled = false

    --变量
    self._isShowed = false
    self._dataDic = {}
    self._numPerPage = numPerPage
    self._pageList = {}
end

function UIPageAndGrid:SetVisible(visible)
    self._gameObject:SetActive(visible)
    self._isShowed = visible
end

function UIPageAndGrid:CreatePage()
    local trs = self._ui:DuplicateAndAdd(self._pageTemp, self._gridTrs, 0)
    trs.name = "page" .. tostring(#self._pageList + 1)
    self._pageList[#self._pageList + 1] = Page.new(trs, self._ui, self._Item, 
                                            self._numPerPage, self._funcOnClick)
    return self._pageList[#self._pageList]
end

function UIPageAndGrid:GetUnShowedPage()
    for _, page in ipairs(self._pageList) do
        if page and not page:IsShowed() then
            return page
        end
    end
    return nil
end

function UIPageAndGrid:GetPage()
    local page = self:GetUnShowedPage()
    if page then
        return page
    else
        return self:CreatePage()
    end
end

function UIPageAndGrid:Show(dataDic)
    self._dataDic = dataDic
    self:SetVisible(true)

    local page = nil
    for idx, dataList in ipairs(self._dataDic) do
        page = self:GetPage()
        if page then
            page:Show(dataList)
        end
    end

    self._grid:Reposition()
end

function UIPageAndGrid:Hide()
    self:SetVisible(false)
    self._dataDic = {}
end

function UIPageAndGrid:SetItemToNor(id)
    for _, page in ipairs(self._pageList) do
        if page and page:IsShowed() then
            page:SetItemToNor(id)
        end
    end
end

function UIPageAndGrid:SetItemToSpec(id)
    for _, page in ipairs(self._pageList) do
        if page and page:IsShowed() then
            page:SetItemToSpec(id)
        end
    end
end

return UIPageAndGrid
-----------------------------UIPageAndGrid-----------------------------
